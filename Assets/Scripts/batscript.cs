using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batscript : MonoBehaviour
{


    public float speed = 2;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if( player == null)
        {
            return;
        }
        Chase();
        
    }


    private void Chase()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed* Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject); // Destroy the bat when it touches the player
        }
    }



    }
