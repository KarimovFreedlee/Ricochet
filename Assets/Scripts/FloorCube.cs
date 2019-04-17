using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCube : MonoBehaviour {
    private int Cubelife;
    public GameObject floor;
    public SpriteRenderer color;
    public Color firstHealthColor;
    public Color secondHealthColor;

    public void Start()
    {
        Cubelife = 3;
        color = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="ball")
        {
            Cubelife--;
            switch (Cubelife)
            {
                case 2:
                    color.color = firstHealthColor;
                    break;
                case 1:
                    color.color = secondHealthColor;
                    break;
                case 0: 
                    Instantiate(floor, new Vector2(0.35f, -5f), Quaternion.identity);
                    Destroy(gameObject);
                    break;
            }
        }
    }
}
