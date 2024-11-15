using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D myBody;

    private Button jumpButton;


    [SerializeField] private float speed = 3f;
    [SerializeField] private float acceleration = 0.5f;
    [SerializeField] private float acceleration_time = 3f;

    void Awake() {
        jumpButton = GameObject.Find("Jump Button").GetComponent<Button>();             // Nama tombol buat karakter loncat = Jump Button
        jumpButton.onClick.AddListener (() => Jump ());
        myBody = GetComponent<Rigidbody2D>();
    }


    void Start() {
        StartCoroutine(Nambah_Kecepatan());
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
    }

    private void Jump() {
        myBody.gravityScale *= -1;
        Vector3 temp = transform.localScale;
        temp.y *= -1;
        transform.localScale = temp;
    }

    IEnumerator Nambah_Kecepatan() {
        while (speed < 10f) {
        yield return new WaitForSeconds(acceleration_time);
        speed += acceleration;
        }
    }
}
