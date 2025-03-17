using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // To use SceneManager for level resetting

public class SpikeScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object colliding with the spike has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Reset the current scene (i.e., restart the level)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
