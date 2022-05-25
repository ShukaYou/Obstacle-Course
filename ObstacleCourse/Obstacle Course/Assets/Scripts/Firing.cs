using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody bullet;
    public Rigidbody rb;

    void Start()
    {
       rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        FireBullet();
    }

    void FireBullet()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;
            clone = Instantiate(bullet, transform.position, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        }
    }
}
