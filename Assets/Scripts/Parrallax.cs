using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parrallax : MonoBehaviour
{


    private float length, startpos;
    public GameObject cam;
    public float parallaxEffect;
    private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
    

        spriteRenderer = GetComponentInChildren<SpriteRenderer>();

        if (spriteRenderer != null)
        {
            startpos = transform.position.x;
            length = spriteRenderer.bounds.size.x;
        }
        else
        {
            Debug.LogError("No SpriteRenderer found in children of " + gameObject.name);
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);
        transform.position = new Vector3(startpos + dist,  transform.position.y, transform.position.z);



       
    }
}
