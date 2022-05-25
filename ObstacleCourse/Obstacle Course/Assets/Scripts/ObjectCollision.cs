using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        Debug.Log("Hit a wall!");
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
