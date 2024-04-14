using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingNoteSKey : MonoBehaviour
{
    public List<float> sKey = new List<float>();
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

        if (Input.GetKey(KeyCode.S))
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

        float timing = (float)System.Math.Round(timingAudio.time, 2);

        foreach (float skeytiming in sKey)
        {
            if (timing - 2.4f == skeytiming - 2.4f)
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
