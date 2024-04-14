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

        foreach (float spacekeytiming in spaceKey)
        {
            if (timing - 2.8f == spacekeytiming - 2.8f)
            {
                Instantiate(note, location);
            }
        }
    }
}
