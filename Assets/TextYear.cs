using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextYear : MonoBehaviour
{
    float timer;
    TextMesh Year;

    // Start is called before the first frame update
    void Start()
    {
        Year = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 10)
        {
            Year.text = "Year 2025";
        }

        if (timer > 20)
        {
            Year.text = "Year 2050";
        }

        if (timer > 30)
        {
            Year.text = "Year 2075";
        }

        if (timer > 40)
        {
            Year.text = "Year 2100";
        }


    }
}
