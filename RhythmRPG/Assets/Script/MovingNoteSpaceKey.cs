using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingNoteSpaceKey : MonoBehaviour
{
    public float force;

    public static bool spacetarget;

    // Start is called before the first frame update
    void Start()
    {
        spacetarget = false;

    }

    // Update is called once per frame
    void Update()
    {
        force = Time.deltaTime * 10;
        transform.Translate(Vector3.left * force, Space.World);

        if (Input.GetKey(KeyCode.Space))
        {
            if (spacetarget == true)
            {
                GameManager.score = 0;
                Destroy(gameObject);
            }
            else if (spacetarget == false)
            {
                return;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PreparedNote")
        {
            spacetarget = true;
        }
        else
        {
            spacetarget = false;
        }
    }
}
