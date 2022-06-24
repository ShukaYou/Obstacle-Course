using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoDmg : MonoBehaviour
{
    playerAbilityHandler pah;
    public GameObject bullet;

    Rigidbody rb;
    
     public float torpedoSpeed = 8f;
    

    // Start is called before the first frame update
    void Start()
    {   
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<Rigidbody>().velocity = transform.right * -1 * torpedoSpeed;
       
    }

    void OnTriggerEnter(Collider other) 
        {
            if ( other.gameObject.tag == "Player2")
            {
                Destroy(bullet);
            }
        }

   
        
}
