using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public TextMeshProUGUI healthstatus;
    
    public static float health; // Health of the enemy (The condition to win)

    public GameObject replay; //will be used later

    // Start is called before the first frame update
    void Start()
    {
        health = 90;
        //replay.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {

        if(ActionGauge.attack == true) //MovingNote (84, 93). Will be determined whether space key was pressed on the right timing or not.
        {
            health = health - ActionGauge.AttackPoint; //Decrease of the enemy's health.
            ActionGauge.AttackPoint = 0; //The player character's Action Gauge will reset

            //for(int i = 0; i < HitBox.totalHit.Length; i++)
            //{
            //    HitBox.totalHit[i] = 0;
            //}

            ActionGauge.attack = false; //Player will not attack again until the next space bar note appears.
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
