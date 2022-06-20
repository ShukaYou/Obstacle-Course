using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAbilityHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody bullet;
    public Rigidbody rb;
    public playerShip Ship;
    public GameObject fireFrom;

    public float bulletSpeed = 10f;
    public float torpedoSpeed = 10f;
    
    public enum playerShip
    {
        Carrier, Sub
    }

    void Start()
    {
        GameObject bullet = GameObject.FindGameObjectWithTag("Bullet");     
       rb = this.GetComponent<Rigidbody>();
       Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        FireBullet();
        
        
        
        if(Ship == playerShip.Carrier)
        {
            
        }

        
    }

    void FireBullet()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 Forward = new Vector3(-1,0,0);
            if(Ship == playerShip.Sub)
        {
            Rigidbody torpedo;
            torpedo = Instantiate(bullet, fireFrom.transform.position, fireFrom.transform.rotation);
            // fireRot = bullet.rotation;
            // Give the cloned object an initial velocity along the current
            // object's Z axis
            Vector3 bv = new Vector3(-1,0,0);
           // Vector3 tpedo = ForceMode.Force = 10;
            torpedo.velocity = fireFrom.transform.TransformDirection(bv * bulletSpeed);
            //rb.AddRelativeForce(Forward * torpedoSpeed);
        }// Instantiate the projectile at the position and rotation of this transform
            
        }
    }
}
