using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazardw7 : MonoBehaviour
{
    public GameObject player;
    public bool follow;
    public bool move;
    public bool loot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        //throw all the collision stuff here or something idk

        // this is the worst way to do colisions ever. if you are an aspiring game developer/programer, please don't do this.
        if (pos.x + 0.5f >= player.transform.position.x && pos.x - 0.5f <= player.transform.position.x) 
        {
            if (loot == true)
            {
                Debug.Log("player has grabbed loot");
            }
            else
            {
                Debug.Log("player has touched a hazard");
            }
        }

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
