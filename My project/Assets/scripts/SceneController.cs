using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public static void entergame()
    {
        SceneManager.LoadScene("town_view");
    }

    public static void exitgame()
    {
        SceneManager.LoadScene("main_menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
