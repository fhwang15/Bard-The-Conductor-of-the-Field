using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class AudioManager : MonoBehaviour
{
    //Main Music
    public AudioSource mainMusic;

    //Skip point for the music
    float musicPointOne = 33.13f;
    float musicPointTwo = 70.1f;
    float musicPointThree = 134.49f;

    //Skip point trigger
    bool musicPointA;
    bool musicPointB;
    bool musicPointC;

  

    // Start is called before the first frame update
    void Start()
    {

        musicPointA = true;
        musicPointB = false;
        musicPointC = false;
        mainMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        musicTime();

        if(mainMusic.isPlaying == true)
        {
            return;
        } else if(mainMusic.isPlaying == false)
        {
            SceneManager.LoadScene(2);
        }
    }

    // Instead of thinking of collision or Raycast whatever, using difference from the actual timestamp.
    
    private void musicTime()
    {
        if (mainMusic.time >= musicPointOne && musicPointA == true)
        {
            musicPointA = false;
            musicPointB = true;
            mainMusic.time = 54.29f;
        }
        else if (mainMusic.time > musicPointTwo && musicPointB == true)
        {
            musicPointB = false;
            musicPointC = true;
            mainMusic.time = 121.35f;
        } 
        else if (mainMusic.time > musicPointThree && musicPointC == true)
        {
            musicPointC = false;
            mainMusic.time = 289.76f;
        }
    }


}
