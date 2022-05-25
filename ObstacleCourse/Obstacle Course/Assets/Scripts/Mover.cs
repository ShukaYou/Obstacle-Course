using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //Variables that affect movement speed                     
    [SerializeField] float movementSpeed = 10f;

    void Start()
    {
       PrintInstructions();
       
    }

    // Update is called once per frame
    void Update()
    { 
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Use the arrow keys to move!");
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        
        transform.Translate(zValue,0,xValue);
    }
}
