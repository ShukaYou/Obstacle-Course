using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 0;


    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Obstacle")
        {
         hits++;
        Debug.Log("You've bumped into something " + hits + " times!"); 
        }
         
    }
}
