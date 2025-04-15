using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassroomMove : MonoBehaviour
{
    // The build index of the scene to load.
    public int sceneBuildIndex;


    // Called when another collider enters this GameObject's trigger collider.
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Trigger Entered");

        // Check if the collider belongs to the player.
        if(other.CompareTag("Player"))
        {
            //SceneManager.sceneLoaded += onSceneLoaded;
            SceneManager.LoadScene("classroom");
        }
    }
}

