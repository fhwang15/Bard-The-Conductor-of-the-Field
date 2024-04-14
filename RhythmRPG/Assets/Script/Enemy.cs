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
        GameManager.attack = false;
        health = 300;
        replay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(GameManager.attack == true) 
        {
            health = health - GameManager.score;
            GameManager.score = 0;
            GameManager.attack = false;
        }

        healthstatus.text = health.ToString();

        EndofGame();

    }

    void EndofGame()
    {
        if (health == 0)
        {
            replay.SetActive(true);
        }
    }


}
