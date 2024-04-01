using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public TextMeshProUGUI healthstatus;
    public float health;

    public GameObject replay;

    // Start is called before the first frame update
    void Start()
    {
        health = 4;
        replay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        healthstatus.text = health.ToString();
        
        if (Input.GetKeyDown(KeyCode.Space) && MovingNoteSpaceKey.spacetarget==true)
        {
            health = health - GameManager.score;
        }


        if(health == 0)
        {
            replay.SetActive(true);
        }
    }
}
