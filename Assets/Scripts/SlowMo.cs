using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMo : MonoBehaviour {
    private int slowerCounter;


    private void Start()
    {
        Time.timeScale = 1f;
        slowerCounter = 2;
    }
    void FixedUpdate () {
        if (Input.GetKeyDown("space"))
        {
            slowerCounter--;
            
            if (slowerCounter != 0)
            {
                StartCoroutine(timeSlower());
            }
        }
        
    }

    IEnumerator timeSlower()
    {
        
        Time.timeScale =0.5f;
        Time.fixedDeltaTime = Time.timeScale * .02f;
        yield return new WaitForSeconds(1);
        
        Time.timeScale = 1f;
        
    }
}
