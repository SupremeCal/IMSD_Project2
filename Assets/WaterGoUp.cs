using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGoUp : MonoBehaviour
{
    float WaterYScale = 0.1f;
    private float timer;
    
    void Start()
    {
        
    }

    void Update()
    {
        //transform.localScale += new Vector3(0, WaterYScale * Time.deltaTime, 0);

        timer += Time.deltaTime;

        if (timer > 0 && timer < 10)
        {
            transform.localScale += new Vector3(0, WaterYScale * Time.deltaTime, 0);
        }

        if(timer > 20 && timer < 30)
        {
            transform.localScale += new Vector3(0, WaterYScale * Time.deltaTime, 0);
        }

    }
}
