using UnityEngine;


public class CubeDestroy : MonoBehaviour {
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            GameOver.cubeCounter--;
            GameOver.playerPoints += 10 * PauseMenu.sceneID;
            Destroy(gameObject);
            Debug.Log(GameOver.cubeCounter);
        }
    }
}
