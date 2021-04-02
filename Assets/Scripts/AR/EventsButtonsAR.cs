using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsButtonsAR : MonoBehaviour
{
    [SerializeField]
    private UnityEvent buttonHit;
    public void OnEvent()
    {
        if(buttonHit != null)
        {
            buttonHit.Invoke();
        }
    }


}
