using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastDedo : MonoBehaviour
{
    [SerializeField]
    float distanceRayCast;

    RaycastHit hit;

    [SerializeField]
    GameObject coreRayCast;
    void Start()
    {
    }

    void FixedUpdate()
    {
        bool isHit = Physics.Raycast(coreRayCast.transform.position, coreRayCast.transform.forward, out hit, distanceRayCast);

        if (isHit)
        {
            try
            {
                hit.transform.GetComponent<MenuAR>().OnScreen();
            }
            catch
            {
                //no haga nada
            }
            Debug.DrawRay(coreRayCast.transform.position, coreRayCast.transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
            
        }
        else
        {
            Debug.DrawRay(coreRayCast.transform.position, coreRayCast.transform.TransformDirection(Vector3.forward) * distanceRayCast, Color.red);

        }
    }
}
