using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionGauge : MonoBehaviour
{

    public HitBox fromHB;

    public static int AttackPoint;

    public int harmonicScore;
    public int greatScore;
    public int goodScore;
    public int plinkScore;
    public int missScore;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void calculation()
    {
        for(int i = 0; i < HitBox.totalHit.Length; i++)
        {
            if(i == 0)
            {
                harmonicScore = HitBox.totalHit[i];
            }
        }
    }

}
