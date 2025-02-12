using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tank_movement : MonoBehaviour
{
    public Slider slide;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (Input.GetAxis("Horizontal") > 0) 
        {
            pos.x += slide.value * Time.deltaTime;
        }
        if (Input.GetAxis("Horizontal") < 0) 
        {
            pos.x -= slide.value * Time.deltaTime;
        }
        transform.position = pos;
    }
}
