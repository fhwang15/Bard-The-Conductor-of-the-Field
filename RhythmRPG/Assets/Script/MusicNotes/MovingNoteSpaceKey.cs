using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class MovingNoteSpaceKey : MonoBehaviour
{

    public List<float> spaceKey = new List<float>();
    public Transform location;
    public AudioSource timingAudio;

    public GameObject note;

    public float force;

    public static bool spacetarget;

    // Start is called before the first frame update
    void Start()
    {
        spacetarget = false;

    }

    // Update is called once per frame
    void Update()
    {
        SummonNotes();
    }

    void SummonNotes()
    {
        float timing = (float)System.Math.Round(timingAudio.time, 2);

        for (int i = spaceKey.Count - 1; i >= 0; i--)
        {
            float spacekeytiming = spaceKey[i];
            if (timing - 2.4f >= spacekeytiming - 2.4f)
            {
                Instantiate(note, location); //Instantiates the music note
                spaceKey.RemoveAt(i);
            }
        }


        //foreach (float spacekeytiming in spaceKey)
        //{
            //if (timing - 2.8f == spacekeytiming - 2.8f)
            //{
                //Instantiate(note, location);
            //}
        //}
    }
}
