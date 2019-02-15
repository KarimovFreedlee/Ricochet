using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour {
    public GameObject panel;
    public bool start;
    private int sceneID;
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKeyDown("escape"))
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
            
        }
	}
    private void Start()
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
        SceneManager.LoadScene(sceneID);
        
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
