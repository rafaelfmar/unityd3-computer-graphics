using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacaoPersonagem : MonoBehaviour
{
    float unidadesTx, unidadesTz;
    float vT;
    bool proxPorta;
    
    // Start is called before the first frame update
    void Start()
    {
        vT = 5.0f;
        proxPorta = false;
    }

    // Update is called once per frame
    void Update()
    {
        unidadesTx = Input.GetAxis("Horizontal") * vT * Time.deltaTime;
        unidadesTz = Input.GetAxis("Vertical") * vT * Time.deltaTime;
        
        transform.Translate(unidadesTx, 0, unidadesTz);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Porta")
        {
            proxPorta = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Porta")
        {
            proxPorta = false;
        }
    }

    private void OnGUI()
    {
        if (proxPorta)
        {
            GUI.Label(
                new Rect(
                    Screen.width/2 - 125, 
                    Screen.height / 2, 
                    250, 
                    30
                ), 
                "F - Abrir/Fechar"  
                ); 
        }
    }
}
