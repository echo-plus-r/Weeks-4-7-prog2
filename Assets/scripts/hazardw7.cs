using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazardw7 : MonoBehaviour
{
    public GameObject player; // holds the player, this is used to calculate positions and such
    public bool follow; // holds if the object should follow the player or not
    public bool move; // holds if the object should move or not
    public bool loot; // holds if the object is loot or a hazard
    SpriteRenderer SpriteRenderer; // holds the sprite render of the object
    hazardw7 script; // holds a refrence to this script
    // Start is called before the first frame update
    void Start()
    {
        // getting the related components
        script = GetComponent<hazardw7>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        // this is the worst way to do colisions ever. if you are an aspiring game developer/programer, please don't do this.
        if (pos.x + 0.5f >= player.transform.position.x && pos.x - 0.5f <= player.transform.position.x) 
        {
            // checking if the object is loot or not
            if (loot == true)
            {
                Debug.Log("player has grabbed loot");

                // making the loot disapear after it is collected
                // again, this is sort of bad code, don't try this at home.
                // the better way to do this would be to destroy the object or something
                SpriteRenderer.enabled = false;
                script.enabled = false;
            }

            // else statement runs if the object is not loot, meaning it's a hazard
            else
            {
                Debug.Log("player has touched a hazard");
            }
        }

        // if statement for following the player
        if (follow == true) 
        {
            // if the object's current position is greater than the player's, remove from the x value
            if (pos.x > player.transform.position.x) 
            {
                pos.x -= 1 * Time.deltaTime;
            }
            // if the object's current position is less than the player's, add from the x value
            if (pos.x < player.transform.position.x) 
            {
                pos.x += 1 * Time.deltaTime;
            }
        }
        transform.position = pos;
    }
}
