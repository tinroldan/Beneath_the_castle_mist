using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastArma : MonoBehaviour
{
    [SerializeField]
    float distanceRayCast;

    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        bool isHit = Physics.Raycast(transform.position, transform.forward, out hit, distanceRayCast);

        if(isHit)
        {
            print("Objeto Golpeado: "+hit.transform.gameObject.tag);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * distanceRayCast, Color.red);

        }

        //if (Physics.Raycast(transform.position, Vector3.forward, out hit, distanceRayCast))
        //{
        //    print("objeto golpeado: " + hit.transform.tag);
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * distanceRayCast, Color.green);

        //}
        //else
        //{
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * distanceRayCast, Color.red);

        //}


    }
}
