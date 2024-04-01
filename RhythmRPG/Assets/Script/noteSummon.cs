using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteSummon : MonoBehaviour
{
    public List<float> aKey = new List<float>();
    public List<float> sKey = new List<float>();
    public List<float> dKey = new List<float>();
    public List<float> fKey = new List<float>();
    public List<float> spaceKey = new List<float>();

    public List<Transform> location = new List<Transform>();

    public AudioSource mainAudio;

    public GameObject note;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(mainAudio.time);

        foreach(float akeytiming in aKey)
        {
            if(akeytiming - 0.2f <= mainAudio.time || akeytiming + 0.2f >= mainAudio.time)
            {
                Instantiate(note, location[0]);
                Debug.Log("working");
            }

        }

        // akeytiming - 0.2 < mainaudio.time < akeytiming + 0.2f
        
    }
}
