using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    static int score = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            score ++;
            Debug.Log(score);
        }
        
    }
}
