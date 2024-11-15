using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     [SerializeField] private float speed = 3f;
    [SerializeField] private float accelaration = 0.5f;
    [SerializeField] private float accelaration_time = 3f;

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

    IEnumerator Nambah_Kecepatan() {
        while (speed < 10f) {
        yield return new WaitForSeconds(accelaration_time);
        speed += accelaration;
        }
    }
}
