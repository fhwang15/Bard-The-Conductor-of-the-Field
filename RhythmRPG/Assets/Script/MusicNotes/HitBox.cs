using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Harmonic")
        {

        } else if(collision.gameObject.tag == "Great")
        {

        } else if (collision.gameObject.tag == "Good")
        {

        } else if (collision.gameObject.tag == "Plink")
        {

        } else
        {

        }
    }


}
