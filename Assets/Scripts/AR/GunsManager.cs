using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsManager : MonoBehaviour
{
    [Header("Armas")]
    [SerializeField]
    GameObject hand;
    [SerializeField]
    GameObject[] guns;


    int gunIndex;
    bool menuAR;


    public void UpdateGun()
    {

        if (menuAR)
        {
            hand.SetActive(true);
            for (int i = 0; i < guns.Length; i++)
            {
                guns[i].SetActive(false);
            }
        }
        else
        {
            hand.SetActive(false);
            for (int i = 0; i < guns.Length; i++)
            {

                guns[i].SetActive(false);
            }
            guns[gunIndex].SetActive(true);
        }
    }

    public void OnMenuAR(bool state)
    {
        menuAR = state;
    }

    public void SetIndexGun(int index)
    {
        gunIndex = index;
    }
}
