using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBallMove : MonoBehaviour {
    public Rigidbody2D ballBody;
    // Use this for initialization
    void Start () {

        ballBody = GetComponent<Rigidbody2D>();
        ballBody.AddForce(new Vector2(Random.Range(-0.01f, 0.01f), 0.04f));    
    }
	
}
