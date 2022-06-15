using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //Variables that affect movement speed                     
    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float rotationSpeed = 3f;
    [SerializeField] Quaternion rotationAmount;
    Rigidbody rb;

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
       // float xValue = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        //float zValue = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        //transform.Translate(xValue,0,zValue);

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 moveForward = new Vector3(1,0,0);
            transform.position += Time.deltaTime * movementSpeed * moveForward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 moveBack = new Vector3(-1,0,0);
            transform.position += Time.deltaTime * movementSpeed * moveBack;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //Vector3 moveLeft = new Vector3(0,0,0);
            //transform.position += Time.deltaTime * movementSpeed * moveLeft;
            //transform.Rotate(Time.deltaTime * rotationSpeed * Vector3.down);
            transform.Rotate(Time.deltaTime * rotationSpeed * Vector3.down);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //Vector3 moveRight = new Vector3(0,0,0);
            //transform.position += Time.deltaTime * movementSpeed * moveRight;
            //transform.Rotate(Time.deltaTime * rotationSpeed * Vector3.down);
            transform.Rotate(Time.deltaTime * rotationSpeed * Vector3.up);
        }
         if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            //Vector3 moveUpLeft = new Vector3(1,0,1);
            rb.AddRelativeForce(Vector3.forward *  movementSpeed);
            rb.AddRelativeForce(Vector3.left *  movementSpeed);
            transform.Rotate(Time.deltaTime * rotationSpeed * Vector3.down);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            //Vector3 moveUpRight = new Vector3(0,0,-1);
           rb.AddRelativeForce(Vector3.forward *  movementSpeed);
            rb.AddRelativeForce(Vector3.right *  movementSpeed);
            transform.Rotate(Time.deltaTime * rotationSpeed * Vector3.up);
        }
    }

    
}
