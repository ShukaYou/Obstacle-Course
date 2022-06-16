using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //Variables that affect movement speed                     
    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float rotationSpeed = 3f;
    [SerializeField] Quaternion rotationAmount;
    public Rigidbody rb;
    

    void Start()
    {
       PrintInstructions();
      rb = gameObject.GetComponent<Rigidbody>();
       
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
       
        //float xMovement = Input.GetAxis("Horizontal") * movementSpeed;
        //float zMovement = Input.GetAxis("Vertical") * movementSpeed;
        Vector3 moveBack = new Vector3(0,0,1);
        Vector3 moveForward = new Vector3(0,0,-1);
      
        if (Input.GetKey(KeyCode.W))
        {
            
            //transform.position += Time.deltaTime * movementSpeed * moveForward;
            rb.AddRelativeForce(moveForward *  movementSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            
            rb.AddRelativeForce(moveBack * movementSpeed);
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
           rb.AddRelativeForce(moveForward *  movementSpeed);
            transform.Rotate(Time.deltaTime * rotationSpeed * Vector3.down);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            //Vector3 moveUpRight = new Vector3(0,0,-1);
           //rb.AddRelativeForce(Vector3() *  movementSpeed);
            rb.AddRelativeForce(moveForward *  movementSpeed);
            transform.Rotate(Time.deltaTime * rotationSpeed * Vector3.up);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            //Vector3 moveUpLeft = new Vector3(1,0,1);
           rb.AddRelativeForce(moveBack *  movementSpeed);
            transform.Rotate(Time.deltaTime * rotationSpeed * Vector3.down);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            //Vector3 moveUpRight = new Vector3(0,0,-1);
           //rb.AddRelativeForce(Vector3() *  movementSpeed);
            rb.AddRelativeForce(moveBack *  movementSpeed);
            transform.Rotate(Time.deltaTime * rotationSpeed * Vector3.up);
        }
    }

    
}
