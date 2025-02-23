using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class plant_act : MonoBehaviour
{
    public Vector2 siz; // used to hold the plant's size
    public Sprite[] sprites; // used to hold sprites the plant can be
    SpriteRenderer sr; // hods the object's sprite renderer
    public TMP_Dropdown dropdown; // holds related dropdown ui element
    bool og = false;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        // getting the sprite rednerer component
        sr = GetComponent<SpriteRenderer>();

        // setting the sprite as a dropdown value
        sr.sprite = sprites[dropdown.value];

        // setting size as the size from a slider
        transform.localScale = siz;

        // this checks the x position of the object, if it's really far away, it's assumed to be the original plant, and therefore should not destroy itself.
        if (transform.position.x > 800) 
        {
            og = true;
        }

        // setting the timer to 0
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // adding to the timer if the plant is not the original one
        if (!og) 
        {
            timer += Time.deltaTime;
        }

        // destroying the plant if the timer is high enough and the plant is not the original one
        if (timer >= 10 && !og) 
        {
            Destroy(gameObject);
        }
    }

    // size is called by a slider.
    public void size(float x) 
    { 
        // copies the value of the slider into a Vector2 that sets the size of a plant in the start function
        siz.x = x;
        siz.y = x;
    }
}
