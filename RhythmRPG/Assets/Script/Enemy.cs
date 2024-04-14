using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public TextMeshProUGUI healthstatus;
    
    public float health; // Health of the enemy (The condition to win)

    public GameObject replay; //will be used later

    // Start is called before the first frame update
    void Start()
    {
        health = 300;
        //replay.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {

        if(GameManager.attack == true) //MovingNote (84, 93). Will be determined whether space key was pressed on the right timing or not.
        {
            health = health - GameManager.score; //Decrease of the enemy's health.
            GameManager.score = 0; //The player character's Action Gauge will reset
            GameManager.attack = false; //Player will not attack again until the next space bar note appears.
        }

        healthstatus.text = health.ToString(); 

        EndofGame(); //Changing scene to the result scene.

    }

    void EndofGame()
    {
        if (health == 0)
        {
            replay.SetActive(true);
        }
    }


}
