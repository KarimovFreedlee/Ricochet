using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreate : MonoBehaviour {
    public GameObject addBallPrefab;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            Instantiate(addBallPrefab, new Vector3(transform.position.x, transform.position.y, 40f), Quaternion.identity);
            GameOver.balls++;
            Destroy(gameObject);
        }
    }

    
}
