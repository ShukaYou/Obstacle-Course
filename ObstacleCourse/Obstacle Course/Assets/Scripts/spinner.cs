using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float xValue = 1.0f;
    [SerializeField] float zValue = 1.0f;
    [SerializeField] float yValue = 1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue,yValue,zValue);
    }
}
