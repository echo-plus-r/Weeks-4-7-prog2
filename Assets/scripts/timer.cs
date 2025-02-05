using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    Slider slide;
    float t;

    void Start()
    {
        slide = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        slide.value = t % slide.maxValue;
    }
}
