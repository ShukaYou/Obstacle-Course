using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFalling : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer mr;
    Rigidbody rb;
    [SerializeField] float dropTimer = 3.0f;
   


    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mr.enabled = false;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        DropItems();
    }

    void DropItems()
    {
        if(Time.time >= dropTimer)
        {
            Debug.Log("ITs past Time");
            rb.useGravity = true;
            mr.enabled = true;
        }
    }
}
