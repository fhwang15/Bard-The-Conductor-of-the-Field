using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovingNote : MonoBehaviour
{

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
        noteMovement();

        if (Input.GetKeyDown(KeyCode.A))
        {
            if(target == true)
            {
                GameManager.score++;
                Destroy(gameObject);
            } else if (target == false) 
            {
                return;
            }
        } else if (Input.GetKeyDown(KeyCode.S)) {

            if (target == true)
            {
                GameManager.score++;
                Destroy(gameObject);
            }
            else if (target == false)
            {
                return;
            }
        } else if (Input.GetKeyDown (KeyCode.D))
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
        } else if(Input.GetKeyDown (KeyCode.F)) {
            
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


    void noteMovement()
    {
        force = Time.deltaTime * 25;
        transform.Translate(Vector3.left * force, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Determines whether the note is in the "note hitting box" area. Allows the player to 
        if (collision.gameObject.tag == "PreparedNote")
        {
            target = true;
        } 
        else
        {
            target = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If the note hits the hitbox at the end of the screen, the note will disappear
        if (collision.gameObject.tag == "Destroyer") 
        {
            target = false;
            Destroy(gameObject);
        }
    }

}
