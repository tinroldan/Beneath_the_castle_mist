using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Animation_Controller : MonoBehaviour
{
    public GameObject jugador, enemigo;
    Animator animator;
    private float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(enemigo.transform.position, jugador.transform.position)<2f){
            tiempo += Time.deltaTime;
            print(tiempo);
            animator.SetBool("Walking", false);
            if (tiempo > 3f)
            {              
                animator.SetTrigger("Attack");
                print("Ataque_mamon");
                tiempo = 0;
            }
        }
        
        else
        {
            animator.SetBool("Walking", true);
        }
       
    }
}
