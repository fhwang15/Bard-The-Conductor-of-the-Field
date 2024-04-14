using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovingNote : MonoBehaviour
{

    public float force;

    bool Atarget;
    bool Starget;
    bool Dtarget;
    bool Ftarget;


    // Start is called before the first frame update
    void Start()
    {
        Atarget = false;
        Starget = false;
        Dtarget = false;
        Ftarget = false;
    }

    // Update is called once per frame
    void Update()
    {
        noteMovement();


        //KeyPressed
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (Atarget == true)
            {
                Atarget = false;
                GameManager.score = GameManager.score + 1;
                Destroy(gameObject);
            }
            else if (Atarget == false)
            {
                return;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S)) {

            if (Starget == true)
            {
                Starget = false;
                GameManager.score++;
                Destroy(gameObject);
            }
            else if (Starget == false)
            {
                return;
            }
        } else if (Input.GetKeyDown (KeyCode.D))
        {
            if (Dtarget == true)
            {
                Dtarget = false;
                GameManager.score++;
                Destroy(gameObject);
            }
            else if (Dtarget == false)
            {
                return;
            }
        } else if(Input.GetKeyDown (KeyCode.F)) {
            
            if (Ftarget == true)
            {
                Ftarget = false;
                GameManager.score++;
                Destroy(gameObject);
            }
            else if (Ftarget == false)
            {
                return;
            }
        }

        if(Input.GetKeyDown (KeyCode.Space))
        {
            if(Atarget == true)
            {
                GameManager.attack = true;
            } else
            {
                return;
            }
        }


    }


    void noteMovement()
    {
        force = Time.deltaTime * 25;
        transform.Translate(Vector3.left * force, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Determines whether the note is in the "note hitting box" area. Allows the player to 
        if (collision.gameObject.tag == "AMovingNote")
        {
            Atarget = true;
        }  else if (collision.gameObject.tag == "SMovingNote")
        {
            Starget = true;
        } else if (collision.gameObject.tag == "DMovingNote")
        {
            Dtarget = true;
        } else if (collision.gameObject.tag == "FMovingNote")
        {
            Ftarget = true;
        }
        else
        {
            Atarget = false;
            Starget = false;
            Dtarget = false;
            Ftarget = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If the note hits the hitbox at the end of the screen, the note will disappear
        if (collision.gameObject.tag == "Destroyer") 
        {
            Atarget = false;
            Starget = false;
            Dtarget = false;
            Ftarget = false;
            Destroy(gameObject);
        }
    }

}
