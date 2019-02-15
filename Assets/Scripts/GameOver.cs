using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public Text text;
    public GameObject panel;
    public GameObject resumeButton;
    public GameObject ball;
    public GameObject nextLevelButton;
    public static int balls;
    public static int cubeCounter;

    private void Awake()
    {
        cubeCounter = 15;
        balls = 1;
    }
    private void FixedUpdate()
    {
        if(cubeCounter==0)
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
            resumeButton.SetActive(false);
            nextLevelButton.SetActive(true);
            text.text = "Level finished!";
        }
    }

    private void OnTriggerExit2D(Collider2D ball)
    {
        balls--;
        if (balls == 0)
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
            resumeButton.SetActive(false);
            text.text = "Game Over!";
        }
    }

    

}
