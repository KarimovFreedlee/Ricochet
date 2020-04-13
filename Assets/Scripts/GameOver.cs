using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GameOver : MonoBehaviour {

    public Text text;
    public GameObject panel, resumeButton, ball, nextLevelButton;
    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5, prefab6, prefab7, prefab8;
    public GameObject[] prefabs1, prefabs2, prefabs3;
    public GameObject[][] prefabsCollection;
    public List<GameObject> prefabsCollections = new List<GameObject>();
    private int percent, minPer, percentForPrefabs, sceneId;
    public static int playerPoints, balls, cubeCounter;
    string currentName;
    int topScore;
    int currentScore;
    private float[] positionsX = { -7.9f, -6.8f, -5.7f, -4.6f, - 3.5f, -2.4f, -1.3f, -0.2f, 0.9f, 2f, 3.1f, 4.2f, 5.3f, 6.4f, 7.5f };
    private float[] positionsY = { 4.5f, 3.4f, 2.3f };

    private void Awake()
    {
        sceneId = SceneManager.GetActiveScene().buildIndex;
        cubeCounter = 0;
        if (sceneId != 1)
        {
            playerPoints = PlayerPrefs.GetInt("currentScore");
        }
        else playerPoints = 0;
        balls = 1;
        topScore = PlayerPrefs.GetInt("points");
        currentName = PlayerPrefs.GetString("currentName");
        minPer = 2;
        CubeCreate();
    }

    private void FixedUpdate()
    {
        if(cubeCounter==0)
        {
            minPer--;
            CubeCreate();
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

    private void CubeCreate()
    {
        percentForPrefabs = Random.Range(0, 2);
        for (int i = 0; i < positionsX.Length; i++)
        {
            for (int j = 0; j < positionsY.Length; j++)
            {
                percent = Random.Range(minPer, 15);
                switch (percent)
                {
                    case 0:
                        Instantiate(prefabsCollection[percentForPrefabs][3], new Vector3(positionsX[i], positionsY[j], 50f), Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(prefabsCollection[percentForPrefabs][2], new Vector3(positionsX[i], positionsY[j], 50f), Quaternion.identity);
                        break;
                    case 2:
                        cubeCounter++;
                        Instantiate(prefabsCollection[percentForPrefabs][1], new Vector3(positionsX[i], positionsY[j], 50f), Quaternion.identity);
                        break;
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                        cubeCounter++;
                        Instantiate(prefabsCollection[percentForPrefabs][0], new Vector3(positionsX[i], positionsY[j], 50f), Quaternion.identity);
                        break;
                }
            }
        }
        
    }

}
