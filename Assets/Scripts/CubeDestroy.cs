using UnityEngine;


public class CubeDestroy : MonoBehaviour {
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            GameOver.cubeCounter--;
            Destroy(gameObject);
        }
    }
}
