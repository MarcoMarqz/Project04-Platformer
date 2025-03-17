using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public Text MyscoreText;
    private int ScoreNum;

    public AudioSource audioSource;    // AudioSource to play sound
    public AudioClip scoreSound;       // AudioClip for score sound


    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Score: " + ScoreNum;

        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if(Coin.tag == "coin" || Coin.tag == "Enemy")
        {
            ScoreNum++;
            MyscoreText.text = "Score: " + ScoreNum;
        }

        if (audioSource != null && scoreSound != null)
        {
            audioSource.PlayOneShot(scoreSound);
        }




    }
}
