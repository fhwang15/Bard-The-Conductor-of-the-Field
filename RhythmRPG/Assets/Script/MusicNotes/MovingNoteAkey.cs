using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MovingNoteAkey : MonoBehaviour
{
    //List of timings
    public List<float> aKey = new List<float>();

    //Location where the notes will be instantiated
    public Transform location;

    //Audio source
    public AudioSource timingAudio;

    //Note Prefab
    public GameObject note;

   // bool target;


    // Start is called before the first frame update
    void Start()
    {
        //target = false;
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

        for(int i = aKey.Count - 1; i >= 0; i--)
        {
            float akeytiming = aKey[i];
            if (timing - 2.4f >= akeytiming - 2.4f)
            {
                Instantiate(note, location); //Instantiates the music note
                aKey.RemoveAt(i);
            }
        }
        
    }
}
