using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingNoteFkey : MonoBehaviour
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
        force = Time.deltaTime * 10;
        transform.Translate(Vector3.left * force, Space.World);

        if (Input.GetKey(KeyCode.F))
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
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PreparedNote")
        {
            target = true;
        }
        else
        {
            target = false;
        }
    }
}
