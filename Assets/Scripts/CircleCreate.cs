using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCreate : MonoBehaviour {

    void Awake()
    {
        if(transform.position.x <= 7f && transform.position.x >= -8.1f)
        {
                Instantiate(this, new Vector3(transform.position.x + 1.1f, transform.position.y,50f), Quaternion.identity);         
        }
        
    }
    
    
}
