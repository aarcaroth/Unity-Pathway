using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // rotation speed of propeller
    public float rpm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotating propeller by the rpm 
        transform.Rotate(Vector3.forward * rpm);
    }
}
