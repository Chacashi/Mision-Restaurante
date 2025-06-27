using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuyTutorial : MonoBehaviour
{
    public GameObject NubePlayer;
    public EfectoTexto TextoCuy;
    public GameObject Cuynube;
    bool Active;
    bool _confirmar;
    sbyte DIALOGOSiNDEXX = 0;
    public ControlerBarrido barrido;
    public CambioScene cambioScene;
    public GameObject botonContinuar;
    private void Start()
    {
        botonContinuar.SetActive(true);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Resepcion")
        {
            _confirmar = true;
            Cuynube.SetActive(true);
            DIALOGOSiNDEXX = 0;
            CuyDialogo(DIALOGOSiNDEXX);
        }
    }

    void Update()
    {
        if (_confirmar && Input.GetKeyDown(KeyCode.Return)) 
        {
            DIALOGOSiNDEXX += 2; 
            CuyDialogo(DIALOGOSiNDEXX);
        }
    }

    public bool Confirmar { get { return _confirmar; } }

    public void CuyDialogo(sbyte n)
    {
        Cuynube.SetActive(true);
        if (n == 0)
        {
            TextoCuy.Inprimir("Primero un pequeño tutorial de las mecanicas esenciales");
        }
        else if (n == 2)
        {
            TextoCuy.Inprimir("En tu area de cocina, tienes 3 zonas importantes");
        }
        else if (n == 4)
        {
            TextoCuy.Inprimir("Primero esta la mesa interactiva, en ella es donde cortaras los ingredientes con el cuchillo");
        }
        else if (n == 6)
        {
            TextoCuy.Inprimir("Despues tenemos la cocina interactiva, aqui se llevara a cabo las combinaciones y el cocinado del arroz, freir las papas y demas");
        }
        else if (n == 8)
        {
            TextoCuy.Inprimir("Y por ultimo tenemos la mesa de platos donde se serviran ya la comida lista para comer");
        }
        else if (n == 10)
        {
            TextoCuy.Inprimir("Intenta practicar con lo siguiente");
        }
        else if (n == 12)
        {
            TextoCuy.Inprimir("Dame unas papas fritas");
        }
        else if (n == 14)
        {
            TextoCuy.Inprimir("Sorprendeme!");
        }
        else
        {
            _confirmar = false;
        }

        NubePlayer.SetActive(false);
    }
    public void ForzarDialogoFinal()
    {
        Cuynube.SetActive(true);
        TextoCuy.Inprimir("¡Felicidades! Has hecho tus primeras papas fritas. ¡Buen trabajo!");
        _confirmar = false;
        NubePlayer.SetActive(false);

        botonContinuar.SetActive(true);
    }
}