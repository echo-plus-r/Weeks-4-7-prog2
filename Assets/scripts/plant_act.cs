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

    // Start is called before the first frame update
    void Start()
    {
        // getting the sprite rednerer component
        sr = GetComponent<SpriteRenderer>();

        // setting the sprite as a dropdown value
        sr.sprite = sprites[dropdown.value];

        // setting size as the size from a slider
        transform.localScale = siz;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // size is called by a slider.
    public void size(float x) 
    { 
        siz.x = x;
        siz.y = x;
    }
}
