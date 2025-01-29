using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class actcanv : MonoBehaviour
{
    public Canvas canvas;
    public Transform ptransform;
    Vector2 actdist = new Vector2(5, 5);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ptransform.position.x >= transform.position.x + actdist.x || ptransform.position.x < transform.position.x - actdist.x)
        {
            canvas.enabled = false;
        }
        else if (ptransform.position.y >= transform.position.y + actdist.y || ptransform.position.y < transform.position.y - actdist.y) 
        {
            canvas.enabled = false;
        }
        else {
            canvas.enabled = true;
        }
    }
}
