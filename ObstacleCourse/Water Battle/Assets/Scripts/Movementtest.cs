using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementtest : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        //movementDirection();

        transform.Translate(movementDirection * speed * Time.deltaTime);
        
        if (movementDirection != Vector3.right)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);            
        }
    }
}