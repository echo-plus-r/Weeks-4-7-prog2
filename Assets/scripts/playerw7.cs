using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerw7 : MonoBehaviour
{
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
            pos.x += 1 * Time.deltaTime;
        }
        if (Input.GetAxis("Horizontal") < 0) 
        {
            pos.x -= 1 * Time.deltaTime;
        }
        transform.position = pos;
    }
}
