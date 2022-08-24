using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gameControllerScript : MonoBehaviour
{

    public GameObject gameOverPanal;
    public GameObject tapToStart;
    public GameObject scoreText;
    public AudioSource audioSource;




    private void Start()
    {
        resumeGame();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            startGame();
        }
    }


    public void gameover()
    {
        //audioSource.Play();
        gameOverPanal.SetActive(true);
        scoreText.SetActive(false);
    }

    public void resumeGame()
    {
        tapToStart.SetActive(true);
        gameOverPanal.SetActive(false);
        Time.timeScale = 0f;
        scoreText.SetActive(false);
    }

    public void startGame()
    {
        tapToStart.SetActive(false);
        Time.timeScale = 1f;
        scoreText.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene("startScene");
    }

    public void quiteGame()
    {
        Application.Quit();
    }



}
