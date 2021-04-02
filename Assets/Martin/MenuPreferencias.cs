using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPreferencias : MonoBehaviour
{
    [SerializeField]
    GameObject manoR, manoL,panel,manoSelectR, manoSelectL;

    public void ActivarR()
    {
        manoR.SetActive(true);
        manoSelectL.SetActive(true);

        manoL.SetActive(false);
        panel.SetActive(false);
        manoSelectR.SetActive(false);

    }

    public void ActivarL()
    {
        manoL.SetActive(true);
        manoSelectR.SetActive(true);

        manoR.SetActive(false);
        panel.SetActive(false);
        manoSelectL.SetActive(false);


    }


}
