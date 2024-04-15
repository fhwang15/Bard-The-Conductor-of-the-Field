using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score;
    public static bool attack;

    


    public TextMeshProUGUI Powerstatus;


    // Start is called before the first frame update
    void Start()
    {
        attack = false;
    }

    // Update is called once per frame
    void Update()
    {


        Powerstatus.text = score.ToString();
    }
}
