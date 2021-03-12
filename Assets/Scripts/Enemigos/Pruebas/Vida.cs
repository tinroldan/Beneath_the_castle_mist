using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour,IColision
{
    [SerializeField] Image barra_vida;
    public float valor_vida;
    // Start is called before the first frame update
    void Start()
    {
        
        barra_vida.fillAmount = valor_vida;
    }
    public void Impacto(){

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            barra_vida.fillAmount -= 1;
        }
    }
}
