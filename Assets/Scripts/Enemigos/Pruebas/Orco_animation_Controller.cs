using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orco_animation_Controller : Enemy_Animation_Controller
{
    
  
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(enemigo.transform.position, jugador.transform.position) < 2f && vida_enemigo.barra_vida.fillAmount > 0.3)
        {
            tiempo += Time.deltaTime;

            animator.SetBool("Walking", false);
            
            if (tiempo > 3f)
            {
                animator.SetTrigger("Attack");
                print("Ataque_mamon");
                tiempo = 0;
            }
        }

        else if (Vector3.Distance(enemigo.transform.position, jugador.transform.position) > 2f && vida_enemigo.barra_vida.fillAmount > 0.3)
        {
            animator.SetBool("Walking", true);
        }
        else if (Vector3.Distance(enemigo.transform.position, jugador.transform.position) > 2f && vida_enemigo.barra_vida.fillAmount < 0.3&&vida_enemigo.barra_vida.fillAmount>0)
        {
            animator.SetBool("Walking", false);
            animator.SetBool("Shield", true);
        }
        else if(Vector3.Distance(enemigo.transform.position, jugador.transform.position) < 1f && vida_enemigo.barra_vida.fillAmount < 0.3 && vida_enemigo.barra_vida.fillAmount > 0)
        {
            tiempo += Time.deltaTime;

            animator.SetBool("Walking", false);
            animator.SetBool("Shield", true);
            if (tiempo > 3f)
            {
                animator.SetBool("Shield", false);
                animator.SetTrigger("Attack");
                tiempo = 0;
            }
        }

        else
        {
            animator.SetBool("Walking", false);
            animator.SetBool("Shield", false);
            animator.SetBool("Die", true);
        }
    }
}
