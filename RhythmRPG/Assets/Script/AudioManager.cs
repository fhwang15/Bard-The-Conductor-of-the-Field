using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



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

    //Time of the AudioSource to other Scripts
  

    //Timing for the notes
    public List<float> aKey = new List<float>();
    public List<float> sKey = new List<float>();
    public List<float> dKey = new List<float>();
    public List<float> fKey = new List<float>();
    public List<float> spaceKey = new List<float>();

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
        
        if (Input.GetKeyDown(KeyCode.A))
        {

            Debug.Log("Akey: " + mainMusic.time);

        } else if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Skey: " + mainMusic.time);

        }
        else if (Input.GetKeyDown(KeyCode.D)) 
        {
            Debug.Log("Dkey: " + mainMusic.time);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Fkey: " + mainMusic.time);

        }
       else if (Input.GetKeyDown(KeyCode.Space))
       {
            Debug.Log("Space key: " + mainMusic.time);

        }

        
            PlayerPrefs.DeleteAll();
        

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
