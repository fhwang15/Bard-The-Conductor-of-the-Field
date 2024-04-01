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
        Debug.Log(mainMusic.time);

        musicTime();
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            //add the timestamp into List A whenever I hit a key
            PlayerPrefs.SetFloat("A Key", mainMusic.time);

        } else if (Input.GetKeyDown(KeyCode.S))
        {
            //add the timestamp into List S whenever I hit s key
            PlayerPrefs.SetFloat("S Key", mainMusic.time);
            //sKey.Add(mainMusic.time);

        }
        else if (Input.GetKeyDown(KeyCode.D)) 
        {
            //add the timestamp into List D whenever I hit d key
            PlayerPrefs.SetFloat("D Key", mainMusic.time);
            //dKey.Add(mainMusic.time);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            //add the timestamp into List F whenever I hit f key
            PlayerPrefs.SetFloat("F Key", mainMusic.time);
            //fKey.Add(mainMusic.time);
        }
       else if (Input.GetKeyDown(KeyCode.Space))
       {
            //add the timestamp into List space whenever I hit space key
            PlayerPrefs.SetFloat("Space Key", mainMusic.time);

            //spaceKey.Add(mainMusic.time);

        }





        if(mainMusic.time >= 345f)
        {
            PlayerPrefs.Save();
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
