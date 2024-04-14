using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class MovingNoteDKey : MonoBehaviour
{

    //List of timings
    public List<float> dKey = new List<float>();

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
       
        SummonNotes(); //Summon the notes

    }

    void SummonNotes() //Will summon the note at the given time.
    {

        //Converts the timing into a float value to the hundredths
        float timing = (float)System.Math.Round(timingAudio.time, 2);

        for (int i = dKey.Count - 1; i >= 0; i--)
        {
            float dkeytiming = dKey[i];
            if (timing - 2.4f >= dkeytiming - 2.4f)
            {
                Instantiate(note, location); //Instantiates the music note
                dKey.RemoveAt(i);
            }
        }



        //foreach (float dkeytiming in dKey)
        //{
            //if (timing - 2.4f == dkeytiming - 2.4f) //Timing adjustment
            //{
                //Instantiate(note, location); //Instantiates the music note
            //}
        //}
    }

}
