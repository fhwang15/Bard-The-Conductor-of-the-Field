using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingNoteFkey : MonoBehaviour
{

    //List of timings
    public List<float> fKey = new List<float>();

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
        float timing = (float)System.Math.Round(timingAudio.time, 2);  //Converts the timing into a float value to the hundredths

        for (int i = fKey.Count - 1; i >= 0; i--)
        {
            float fkeytiming = fKey[i];
            if (timing - 2.4f >= fkeytiming - 2.4f)
            {
                Instantiate(note, location); //Instantiates the music note
                fKey.RemoveAt(i);
            }
        }


        //foreach (float fkeytiming in fKey)
        //{
            //if (timing - 2.4f == fkeytiming - 2.4f) //Timing adjustment
            //{
                //Instantiate(note, location); //Instantiates the music note
            //}
        //}
    }
}
