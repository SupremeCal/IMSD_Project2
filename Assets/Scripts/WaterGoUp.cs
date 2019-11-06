using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGoUp : MonoBehaviour
{
    float WaterYScale = 0.1f;
    private float timer;
    public Light DayandNight;
    float r;
    
    void Start()
    {
        DayandNight.color = Color.white;
    }

    void Update()
    {
        //transform.localScale += new Vector3(0, WaterYScale * Time.deltaTime, 0);

        timer += Time.deltaTime;
        //Day and Night color change
        r = (Mathf.Sin(timer * 3) / 2) + .5f;

        if (timer > 0 && timer < 10)
        {
            transform.localScale += new Vector3(0, WaterYScale * Time.deltaTime, 0);
            DayandNight.color = new Color(r,r,r);
        }

        if(timer > 20 && timer < 30)
        {
            transform.localScale += new Vector3(0, WaterYScale * Time.deltaTime, 0);
            DayandNight.color = new Color(r, r, r);
        }

        if (timer > 40 && timer < 50)
        {
            transform.localScale += new Vector3(0, WaterYScale * Time.deltaTime, 0);
            DayandNight.color = new Color(r, r, r);
        }

        if (timer > 60 && timer < 70)
        {
            transform.localScale += new Vector3(0, WaterYScale * Time.deltaTime, 0);
            DayandNight.color = new Color(r, r, r);
        }

    }
}
