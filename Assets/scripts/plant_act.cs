using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class plant_act : MonoBehaviour
{
    public Vector2 siz;
    //public Vector2 test;
    //public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        //Vector2 sca = transform.localScale;
        //slider = GetComponent<Slider>();

        //sca.x = test.x;
        //sca.y = test.y;

        //transform.localScale = sca;
        transform.localScale = siz;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void size(float x) 
    { 
        //test.x = x;
        //test.y = x;
        siz.x = x;
        siz.y = x;
    }
}
