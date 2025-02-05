using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaytimeSlider : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    Slider slide;
    void Start()
    {
        slide = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        slide.maxValue = clip.length;
        if (source.isPlaying)
        {
            slide.value = source.time;   
        }
    }
}
