using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //Variables that affect movement speed                     
    [SerializeField] float movementSpeed = 10.0f;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    { 
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime *movementSpeed;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime *movementSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
