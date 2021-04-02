using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityStandardAssets.Characters.ThirdPerson
{
    public class Mov_Orco : Enemigo_Mov
    {
        
        float distance;
        
        void Update()
        {
            distance = Vector3.Distance(target.transform.position, transform.position);          
            if (target != null)
                agent.SetDestination(target.transform.position);

            if (vida_enemigo.barra_vida.fillAmount >= 0.3)
            {

            
                if (distance > agent.stoppingDistance )
                {
                    character.Move(agent.desiredVelocity, false, false);
                }
            }
            else
            {
                agent.Stop();
            }
           
                                
        }

       
    }
}
