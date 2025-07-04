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

    public GameObject flecha1;
    public GameObject flecha2;
    public GameObject flecha3;
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

        // Primero, desactiva todas las flechas
        flecha1.SetActive(false);
        flecha2.SetActive(false);
        flecha3.SetActive(false);

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
            flecha1.SetActive(true);
        }
        else if (n == 6)
        {
            TextoCuy.Inprimir("Despues tenemos la cocina interactiva, aqui se llevara a cabo las combinaciones y el cocinado del arroz, freir las papas y demas");
            flecha1.SetActive(false);
            flecha2.SetActive(true);
        }
        else if (n == 8)
        {
            TextoCuy.Inprimir("Y por ultimo tenemos la mesa de platos donde se serviran ya la comida lista para comer");
            flecha2.SetActive(false);
            flecha3.SetActive(true);
        }
        else if (n == 10)
        {
            TextoCuy.Inprimir("Intenta practicar con lo siguiente");
            flecha3.SetActive(false);
        }
        else if (n == 12)
        {
            TextoCuy.Inprimir("Dame unas papas fritas");
        }
        else if (n == 14)
        {
            TextoCuy.Inprimir("¡Sorprendeme!");
        }
        else
        {
            _confirmar = false;
        }
    }
    public void ForzarDialogoFinal()
    {
        NubePlayer.SetActive(true);
        Cuynube.SetActive(true);
        TextoCuy.Inprimir("¡Felicidades! Has hecho tus primeras papas fritas. ¡Buen trabajo!");
        _confirmar = false;
        //NubePlayer.SetActive(false);

        botonContinuar.SetActive(true);
    }
}