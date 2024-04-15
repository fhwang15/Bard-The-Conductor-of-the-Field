using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class HitBox : MonoBehaviour
{

    public static int harmonic;
    public static int great;
    public static int good;
    public static int plink;
    public static int miss;

    float hitdistance;
    public Transform hitrange;


    public bool[] hitLevel = new bool[5]; // 0 = Harmonic, 0-4;
    public static int[] totalHit = new int[5]; //0 = Harmonic, 0-4;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < hitLevel.Length; i++)
        {
            hitLevel[i] = false;
            totalHit[i] = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        hitLocation();

    }

    void hitLocation()
    {

        float dist = Mathf.Abs(hitrange.position.x - gameObject.transform.position.x);

        hitLevel[4] = dist > 1.44f ?  true : false;
        hitLevel[3] = dist <= 1.44f || dist > 0.87f ? true : false;
        hitLevel[2] = dist <= 0.87f || dist > 0.59f ? true : false;
        hitLevel[1] = dist <= 0.59 || dist > 0.28f ? true : false;
        hitLevel[0] = dist <= 0.28f ? true : false;

    }            
}
