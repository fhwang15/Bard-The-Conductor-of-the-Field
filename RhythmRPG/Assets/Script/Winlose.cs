using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Winlose : MonoBehaviour
{
    public TextMeshProUGUI Result;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Enemy.health <= 5)
        {
            Result.text = "You Win!";
        }
        else
        {
            Result.text = "You Lose!";
        }
    }
}
