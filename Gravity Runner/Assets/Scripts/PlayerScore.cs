using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText;
    public float score = 0;

    // Start is called before the first frame update
    void Awake()
    {
        scoreText = GameObject.Find("ScoreBar").GetComponent<TextMeshProUGUI>();
        scoreText.text = "0";
    }

    void Update()
    {
        Vector3 temp = transform.position;
        score = (temp.x + 29.2707f) * 100;
        scoreText.text = score.ToString("0");
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Obstacle")
        {
            transform.position = new Vector3(0, 1000, 0);
            target.gameObject.SetActive(false);
            StartCoroutine(RestartGame());
        }
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSecondsRealtime (2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
