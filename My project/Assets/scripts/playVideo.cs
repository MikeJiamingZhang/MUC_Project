using System;
using System.IO;
using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class playVideo : MonoBehaviour
{
    public VideoPlayer videoplayer;
    private String label;
    private Boolean correct;

    public TextMeshProUGUI labelDisplay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nextVideo();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Return the (label, correct?) where corect is basically game vs non-game
    // Yes for game file (correct)
    // No for non-game files (incorrect)
    private (String, bool) playAnnotateVideo(){
        string videoPath = Path.Combine(Application.streamingAssetsPath, "dataset");;
        string[] videoList = Directory.GetFiles(videoPath, "*.mp4");
        string videoSelected = videoList[UnityEngine.Random.Range(0, videoList.Length)];
        videoplayer.url = videoSelected;
        videoplayer.isLooping = true;
        videoplayer.Play();
        bool correct = true;
        String name = Path.GetFileNameWithoutExtension(videoSelected);
        if(name.Contains("_ng")){
            correct = false;
            name = name.Substring(0, videoSelected.Length - 3);
        }
        labelDisplay.text = name; // set text
        return (name, correct);
    }

    // Logic Handling for student answer questions
    public void clickYes(){
        if(correct){
            answeredCorrectly();
        }
        else{
            answeredWrong();
        }
    }

    public void clickNo(){
        if(!correct){
            answeredCorrectly();
        }
        else{
            answeredWrong();
        }
    }

     public void clickMaybe(){ // current does samething as no, what do you wanna do Jade?
        if(!correct){
            answeredCorrectly();
        }
        else{
            answeredWrong();
        }
    }

    public void nextVideo(){
        (label, correct) = playAnnotateVideo();
    }

    //TODO
    private void answeredCorrectly(){
        // Jade, what do you wanna do if answered correctly?
        Debug.Log("Answered Correct!");

    }

    //TODO
    private void answeredWrong(){
        // Jade, what do you wanna do if answered Wrong?
        Debug.Log("Anwered Wrong!");
    }

}
