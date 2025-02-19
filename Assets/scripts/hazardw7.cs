using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazardw7 : MonoBehaviour
{
    public GameObject player;
    public bool follow;
    public bool move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        //throw all the collision stuff here or something idk

        if (follow == true) 
        {
            if (pos.x > player.transform.position.x) 
            {
                pos.x -= 1 * Time.deltaTime;
            }
            if (pos.x < player.transform.position.x) 
            {
                pos.x += 1 * Time.deltaTime;
            }
        }
        transform.position = pos;
    }
}
