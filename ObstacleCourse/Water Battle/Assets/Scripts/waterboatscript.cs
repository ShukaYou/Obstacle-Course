using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PhysicsHelp;


public class waterboatscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Motor;
    public float SteerPower = 500f;
    public float Power = 5f;
    public float MaxSpeed = 10f;
    public float Drag = 0.1f;

    protected Rigidbody Rigidbody;
    protected Quaternion StartRotation;


 void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        StartRotation = Motor.localRotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var forceDirection = transform.forward;
        var steer = 0;

        //steer direction
        if(Input.GetKeyDown(KeyCode.A))
        {
            steer = 1;
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            steer = -1;
        }

        //rotationalForce
        Rigidbody.AddForceAtPosition(steer * transform.right * SteerPower / 100f, Motor.position);

        var forward = Vector3.Scale(new Vector3(1,0,1), transform.forward);

        //forward and backward power
         if(Input.GetKeyDown(KeyCode.W))
        {
            PhysicsHelper.ApplyForceToReachVelocity(Rigidbody, forward * MaxSpeed, Power);
        }
         if(Input.GetKeyDown(KeyCode.S))
        {
            PhysicsHelper.ApplyForceToReachVelocity(Rigidbody, forward * -MaxSpeed, Power);
        }
        
    }
}
