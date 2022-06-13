using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floater : MonoBehaviour
{

    public Rigidbody rigidBody;
    public float depthBeforeSubmerged = 1f;
    public float displacementAmount = 3f;
    public int FloaterCount = 1;
    public float waterDrag = 0.99f;
    public float waterAngularDrag = 0.5f;
    // Start is called before the first frame update
    private void FixedUpdate() 
    {
        rigidBody.AddForceAtPosition(Physics.gravity / FloaterCount, transform.position, ForceMode.Acceleration);

        float waveHeight = WaveManager.instance.GetWaveHeight(transform.position.x);
     if (transform.position.y < waveHeight)
     {
        float displacementMultiplier = Mathf.Clamp01((waveHeight -transform.position.y) / depthBeforeSubmerged) * displacementAmount;
        rigidBody.AddForceAtPosition(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), transform.position, ForceMode.Acceleration);
        rigidBody.AddForce(displacementMultiplier * -rigidBody.velocity * waterDrag * Time.deltaTime, ForceMode.VelocityChange);
        rigidBody.AddTorque(displacementMultiplier * -rigidBody.angularVelocity * waterAngularDrag * Time.deltaTime, ForceMode.VelocityChange);
     }    

    }
}
