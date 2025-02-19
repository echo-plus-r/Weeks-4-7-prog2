using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazardw7 : MonoBehaviour
{
    public GameObject player;
    public bool follow;// holds if the object should follow the player or not
    public bool move;// holds if the object should move or not
    public bool loot;// holds if the object is loot or a hazard
    SpriteRenderer SpriteRenderer;
    hazardw7 script;
    // Start is called before the first frame update
    void Start()
    {
        script = GetComponent<hazardw7>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
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

                // making the loot disapear after it is collected
                // again, this is sort of bad code, don't try this at home.
                // the better way to do this would be to destroy the object or something
                SpriteRenderer.enabled = false;
                script.enabled = false;
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
