using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerw7 : MonoBehaviour
{
    public float speed;
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
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetAxis("Horizontal") < 0) 
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
