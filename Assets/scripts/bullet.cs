using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    public Sprite[] sprite;
    // Start is called before the first frame update
    void Start()
    {
        //SpriteRenderer.sprite = sprite[];
        Destroy(gameObject, 5f);        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += 5 * Time.deltaTime;
        transform.position = pos;
    }
}
