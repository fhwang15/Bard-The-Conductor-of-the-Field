using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingNoteSKey : MonoBehaviour
{


    //List of timings
    public List<float> sKey = new List<float>();

    //Location where the notes will be instantiated
    public Transform location;

    //Audio source
    public AudioSource timingAudio;

    //Note Prefab
    public GameObject note;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Summon the notes
        SummonNotes();




    }

    void SummonNotes() //Will summon the note at the given time.
    {

        float timing = (float)System.Math.Round(timingAudio.time, 2);
        //Converts the timing into a float value to the hundredths


        foreach (float skeytiming in sKey)
        {
            if (timing - 2.4f == skeytiming - 2.4f) //Timing adjustment
            {
                Instantiate(note, location); //Instantiates the music note
            }
        }
    }
}
