using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioInterfas : MonoBehaviour
{
    public GameObject Sale;
    public GameObject Entra;
    float Tiempo=0.25f;
    float TiempoIncial = 0;
    bool Comenzar;
    private void Update()
    {
        if (Comenzar == true)
        {
            TiempoIncial += Time.deltaTime;
        }
        if (Tiempo <= TiempoIncial)
        {
            Sale.SetActive(false);
            Entra.SetActive(true);
            Comenzar = false;
            TiempoIncial = 0;
        }
    }
    public void Cambio_Intefas()
    {
        Comenzar = true;
    }

}
