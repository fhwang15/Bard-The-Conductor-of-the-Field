using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

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
       
        if (Input.GetKeyDown(KeyCode.A))
        {
            aKey.Add((float)System.Math.Round(mainAudio.time, 2));
        }
        
        else if (Input.GetKeyDown(KeyCode.S))
        {
            sKey.Add((float)System.Math.Round(mainAudio.time, 2));
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            dKey.Add((float)System.Math.Round(mainAudio.time, 2));
        }

        else if (Input.GetKeyDown(KeyCode.F))
        {
            fKey.Add((float)System.Math.Round(mainAudio.time, 2));
        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceKey.Add((float)System.Math.Round(mainAudio.time, 2));
        }

    }
}
