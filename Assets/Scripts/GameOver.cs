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
    public static int playerPoints;
    string currentName;
    int topScore;
    int currentScore;
    

    private void Awake()
    {
        if(PauseMenu.sceneID != 1)
        {
            playerPoints = PlayerPrefs.GetInt("currentScore");
        }
        else playerPoints = 0;
        cubeCounter = 15;
        balls = 1;
        topScore = PlayerPrefs.GetInt("points");
        currentName = PlayerPrefs.GetString("currentName");
    }

    private void FixedUpdate()
    {
        if(cubeCounter==0)
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
            resumeButton.SetActive(false);
            nextLevelButton.SetActive(true);
            text.text = "Level finished! You have "+playerPoints;
            PlayerPrefs.SetInt("currentScore", playerPoints);
            if(playerPoints > topScore)
            {
                PlayerPrefs.SetInt("points", playerPoints);
                PlayerPrefs.SetString("topName", currentName);
            }
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
            text.text = "Game Over! You have "+ playerPoints;
            if (playerPoints > topScore)
            {
                PlayerPrefs.SetInt("points", playerPoints);
                PlayerPrefs.SetString("topName", currentName);
            }
        }
    }

    

}
