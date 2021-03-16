using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastArma : MonoBehaviour
{
    [SerializeField]
    float distanceRayCast, shootForce, fireRate;
    float m_FireRate;

    RaycastHit hit;

    [SerializeField]
    GameObject shootprefab, coreRayCast;


    void Start()
    {

    }

    void FixedUpdate()
    {

        bool isHit = Physics.Raycast(coreRayCast.transform.position, coreRayCast.transform.forward, out hit, distanceRayCast);

        if (isHit && hit.transform.gameObject.tag == "enemy")
        {
            Debug.DrawRay(coreRayCast.transform.position, coreRayCast.transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
            if (shootprefab != null)
            {
                if(m_FireRate>0)
                {
                    m_FireRate -= Time.deltaTime;
                }
                else if(m_FireRate<=0)
                {
                    Shoot();
                    m_FireRate = fireRate;
                }
            }
            else
            {
                print("Esta arma no tiene un objeto para disparar");

            }
        }
        else
        {
            Debug.DrawRay(coreRayCast.transform.position, coreRayCast.transform.TransformDirection(Vector3.forward) * distanceRayCast, Color.red);

        }


    }

    void Shoot()
    {
        GameObject shoot = Instantiate(shootprefab, coreRayCast.transform.position, coreRayCast.transform.rotation);
        Rigidbody rb = shoot.GetComponent<Rigidbody>();
        rb.AddForce(coreRayCast.transform.forward * shootForce, ForceMode.Impulse);

    }
}
