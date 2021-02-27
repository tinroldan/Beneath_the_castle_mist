using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IA_Enemigo : MonoBehaviour
{
    private GameObject jugador;
    public NavMeshAgent agent;
    [SerializeField] float velocidad;
    private float distancia = 50;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(jugador.transform.position , transform.position) < distancia){
            agent.SetDestination(jugador.transform.position);
            agent.speed = velocidad;
        }
        else{
            agent.speed = 0;
        }
    }
}
