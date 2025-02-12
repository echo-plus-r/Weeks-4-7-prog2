using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class tank_cannon : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;

        rot.z = Input.mousePosition.x - Input.mousePosition.y;

        if (Input.GetMouseButtonUp(0)) 
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }

        transform.eulerAngles = rot;
    }
}
