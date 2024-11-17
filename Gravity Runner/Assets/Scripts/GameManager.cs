using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Canvas mainUI;
    Canvas endScreen;
    PlayerDeath playerDeath;

    void Awake()
    {
        mainUI = GameObject.Find("Main Canvas").GetComponent<Canvas>();
        endScreen = GameObject.Find("GameOver").GetComponent<Canvas>();
        playerDeath = GameObject.Find("Player").GetComponent<PlayerDeath>();
        mainUI.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);
    }

    void Update()
    {
        if (playerDeath.playerHasDied == true)
        {
            mainUI.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
        }
    }

    public void OnReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
