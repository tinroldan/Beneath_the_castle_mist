using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastDedo : MonoBehaviour
{

    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1, Color.green);
    }
}
