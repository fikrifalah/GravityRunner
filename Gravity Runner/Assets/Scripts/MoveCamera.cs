using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float acceleration = 0.5f;
    [SerializeField] private float acceleration_time = 3f;    
    [SerializeField] private float kecepatan_Maks = 10f;

    void Start() 
    {
        StartCoroutine(Nambah_Kecepatan());
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
    }
    IEnumerator Nambah_Kecepatan() 
    {
        while (speed < kecepatan_Maks) 
        {
        yield return new WaitForSeconds(acceleration_time);
        speed += acceleration;
        }
    }
}
