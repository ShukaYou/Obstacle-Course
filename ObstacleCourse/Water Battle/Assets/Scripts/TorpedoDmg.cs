using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoDmg : MonoBehaviour
{
    playerAbilityHandler pah;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
        {
            if ( other.gameObject.tag == "Player2")
            {
                Destroy(bullet);
            }
        }
}
