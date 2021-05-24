using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
     int score = 0;
   
   
    //oncollisionenter is used to detect collisons
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag);
        scorecalculator();





    }
    void scorecalculator()
    {
        score++;
        print("score is:" + score);
    }

}
