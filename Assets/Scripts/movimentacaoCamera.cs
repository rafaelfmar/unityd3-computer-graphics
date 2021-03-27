using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacaoCamera : MonoBehaviour
{
    float unidadesRx, unidadesRy;
    float vR;
    public GameObject personagem;
    
    // Start is called before the first frame update
    void Start()
    {
        vR = 50f;
        unidadesRx = 0f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        unidadesRx += Input.GetAxis("Mouse Y") * vR * Time.deltaTime;
        unidadesRx = Mathf.Clamp(unidadesRx, -60f, 60f);
        transform.localEulerAngles = new Vector3(-unidadesRx, 0, 0);
        
        unidadesRy = Input.GetAxis("Mouse X") * vR * Time.deltaTime;
        personagem.transform.Rotate(0, unidadesRy, 0);
    }
}
