using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Animation_Controller : MonoBehaviour
{
    public GameObject jugador, enemigo;
    protected Animator animator;
    protected float tiempo;
    public Vida vida_enemigo;
    public float distancia;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(enemigo.transform.position, jugador.transform.position)< distancia && vida_enemigo.barra_vida.fillAmount>0){
            tiempo += Time.deltaTime;

            animator.SetBool("Walking", false);
            if (tiempo > 3f)
            {              
                animator.SetTrigger("Attack");
                tiempo = 0;
            }
        }
        
        else if(Vector3.Distance(enemigo.transform.position, jugador.transform.position) > distancia && vida_enemigo.barra_vida.fillAmount > 0)
        {
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
            animator.SetBool("Die", true);
        }
    }
}
