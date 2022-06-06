using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{

    
    private void OnCollisionEnter(Collision other) 
    {
       if(other.gameObject.tag == "Player")
       {
           GetComponent<MeshRenderer>().material.color = Color.green;
           gameObject.tag = "hit";
       }
        
    }
}
