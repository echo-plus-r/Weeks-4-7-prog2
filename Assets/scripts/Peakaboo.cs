using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peakaboo : MonoBehaviour
{
    public SpriteRenderer sr;
    public Peakaboo pb;
    public GameObject go;
    public AudioSource auso;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            //sr.enabled = false;
            //pb.enabled = false;
            go.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            //sr.enabled = true;
            //pb.enabled = true;
            go.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            
            if (auso.isPlaying == false) 
            {
                //auso.Play();
                auso.PlayOneShot(clip);

            }
            
            
        }
    }
}
