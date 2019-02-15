using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private int moveSpeed = 15;
    private Rigidbody2D cubeBody;

    private void Start()
    {
        Time.timeScale = 1f;
        cubeBody = GetComponent<Rigidbody2D>();
    }
    void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        move(horizontal);
	}

    public void move(float horizontal)
    {
        
        cubeBody.velocity = new Vector2(horizontal * moveSpeed, cubeBody.velocity.y); 
        
    }
}
