using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGoUp : MonoBehaviour
{
    float WaterYPos = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(0, WaterYPos * Time.deltaTime, 0);

    }
}
