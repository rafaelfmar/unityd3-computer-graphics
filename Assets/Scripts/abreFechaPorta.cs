using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abreFechaPorta : MonoBehaviour
{
    float angulo;
    bool fechada;
    // Start is called before the first frame update
    void Start()
    {
        angulo = 90f;
        fechada = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (fechada)
            {
                transform.Rotate(0, -angulo, 0);
                fechada = false;
            }
            else
            {
                transform.Rotate(0, angulo, 0);
                fechada = true;
            }
        }
    }
}
