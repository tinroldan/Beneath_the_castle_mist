using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAR : MonoBehaviour
{
    [SerializeField]
    GameObject screenMain;
    [SerializeField]
    List<GameObject> otherScreens = new List<GameObject>();

    private void Start()
    {
        screenMain.SetActive(false);

    }
    public void OnScreen()
    {
        screenMain.SetActive(true);
        foreach (var item in otherScreens)
        {
            item.SetActive(false);
        }
    }
}
