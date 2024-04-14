using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MovingNoteAkey : MonoBehaviour
{

    public List<float> aKey = new List<float>();
    public Transform location;
    public AudioSource timingAudio;

    public GameObject note;

    public float force;

    bool target;

    // Start is called before the first frame update
    void Start()
    {
        target = false;

    }

    // Update is called once per frame
    void Update()
    {
        SummonNotes();

        Debug.Log((float)System.Math.Round(timingAudio.time, 2));
        
        if (Input.GetKey(KeyCode.A))
        {
            if (target == true)
            {
                GameManager.score++;
                Destroy(gameObject);
            }
            else if (target == false)
            {
                return;
            }
        }

    }

    void SummonNotes()
    {
        //float tEditor = 1.6f;
        float timing = (float)System.Math.Round(timingAudio.time, 2);


        foreach (float akeytiming in aKey)
        {
            if (timing - 2.4f == akeytiming - 2.4f)
            {
                Instantiate(note, location);
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PreparedNote")
        {
            target = true;
        }
        else
        {
            target = false;
        }
    }
}
