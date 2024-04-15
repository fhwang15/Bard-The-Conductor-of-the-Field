using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class ActionGauge : MonoBehaviour
{
    public TextMeshProUGUI Powerstatus;

    public static int AttackPoint;

    public static bool attack;

    //public int harmonicScore;
    //public int greatScore;
    //public int goodScore;
    //public int plinkScore;
    //public int missScore;


    // Start is called before the first frame update
    void Start()
    {
        attack = false;
    }

    // Update is called once per frame
    void Update()
    {
        //calculation();
        Powerstatus.text = AttackPoint.ToString();
    }

    //void calculation()
    //{
    //    harmonicScore = (HitBox.totalHit[0] * 5);
    //    greatScore = (HitBox.totalHit[1] * 3);
    //    goodScore = (HitBox.totalHit[2] * 2);
    //    plinkScore = (HitBox.totalHit[3] * 1);
    //    missScore = (HitBox.totalHit[4] * -1);

    //    AttackPoint = harmonicScore + greatScore + goodScore + plinkScore + missScore;

    //}

}
