using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private float Mantimer;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        Mantimer += Time.deltaTime;

        //transform.position += new Vector3(1 * Time.deltaTime, 0 , 0);

        if (Mantimer > 0 && Mantimer < 10)
        {
            transform.position += new Vector3(0.36f * Time.deltaTime, 0, 0);
            
        }

        if (Mantimer > 20 && Mantimer < 30)
        {
            transform.position += new Vector3(0.36f * Time.deltaTime, 0, 0);

        }

        if (Mantimer > 40 && Mantimer < 50)
        {
            transform.position += new Vector3(0.36f * Time.deltaTime, 0, 0);

        }
    }
}
