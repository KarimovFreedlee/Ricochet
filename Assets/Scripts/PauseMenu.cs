using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour {

    public GameObject panel;
    
    
    public static int sceneID;
    
   
	
	void FixedUpdate () {
        
        if (Input.GetKeyDown("escape"))
        {
                Time.timeScale = 0f;
                panel.SetActive(true); 
        }

        // quick level dont forget to delet this
        if (Input.GetKeyDown("q"))
        {
            GameOver.cubeCounter = 0;
        }
    }
    private void Awake()
    {
        
        sceneID = SceneManager.GetActiveScene().buildIndex;
    }

    public void OnMouseClick()
    {
        panel.SetActive(false);
        
        Time.timeScale = 1;
    }
    public void OnRestartButton()
    {
        SceneManager.LoadScene(1);
        
    }
    public void OnMainMenuButton()
    {
        SceneManager.LoadScene(0);

    }

    public void NextLevel()
    {
        SceneManager.LoadScene(sceneID+1);
    }
    
    public void PrevLevel()
    {
        SceneManager.LoadScene(sceneID-1);
    }

    
}
