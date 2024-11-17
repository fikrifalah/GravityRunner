using System.Collections;
using System.Collections.Generic;

using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{   
    public bool playerHasDied = false;
    void Awake()
    {

    }

    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Obstacle")
        {
            transform.position = new Vector3(0, 1000, 0);
            target.gameObject.SetActive(false);
            playerHasDied = true;
        }
    }

}
