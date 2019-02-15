using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreate : MonoBehaviour {
    public GameObject prefab1, prefab2, prefab3, prefab4;
    public int percent;
    public float maxY;
    public float minY;
    public int minPer;
    
    // Use this for initialization
    private void Start()
    {
        
        if (transform.position.y <= maxY && transform.position.y >= minY)
        {
            percent = Random.Range(minPer, 15);
            switch (percent)
            {
                case 0:
                    Instantiate(prefab4, new Vector3(transform.position.x, transform.position.y - 1.1f, 50f), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(prefab3, new Vector3(transform.position.x, transform.position.y - 1.1f, 50f), Quaternion.identity);
                    break;
                case 2:
                    GameOver.cubeCounter++;
                    Instantiate(prefab2, new Vector3(transform.position.x, transform.position.y - 1.1f, 50f), Quaternion.identity);
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
                    GameOver.cubeCounter++;
                    Instantiate(prefab1, new Vector3(transform.position.x, transform.position.y - 1.1f, 50f), Quaternion.identity);
                    
                    break;
            }
            
        }
    }
}
