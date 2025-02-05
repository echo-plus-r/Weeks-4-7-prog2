using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taperotation : MonoBehaviour
{
    public AudioSource source;
    Vector3 rot;
    void Start()
    {
        rot = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (source.isPlaying)
        {
            rot.z -= 300 * Time.deltaTime;
        }
        transform.eulerAngles = rot;
    }
}
