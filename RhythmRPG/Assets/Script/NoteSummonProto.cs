using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NoteSummonProto : MonoBehaviour
{

    public AudioSource mainaudio;
    public TextMeshProUGUI audiotime;
    float testing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        testing = (float)System.Math.Round(mainaudio.time, 2);
        audiotime.text = testing.ToString();
    }
}
