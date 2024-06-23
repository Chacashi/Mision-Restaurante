using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEditorInternal;
using UnityEngine;

public class Construir_Ingredientes : MonoBehaviour
{
    public TablaControl[] Tablas;
    public bool[] IngredientesEchos;
    public GameObject[] Generadores;

    private void Update()
    {
        if (Tablas[0].Confirmar == true && Tablas[1].Confirmar == true)
        {
            if (Tablas[0].Ingrediente.GetComponent<Cuchillo>()  && Tablas[1].Ingrediente.GetComponent<Cebolla>() ||
                Tablas[0].Ingrediente.GetComponent<Cebolla>() && Tablas[1].Ingrediente.GetComponent<Cuchillo>() )
            {
                Cuchillo cuchillo = new Cuchillo();
                Cebolla cebolla = new Cebolla();    
                Contruir(cuchillo, cebolla);
                Tablas[0].Limpiar();
                Tablas[1].Limpiar();
                print("Creado");
            }
            else if (Tablas[0].Ingrediente.GetComponent<Cuchillo>() && Tablas[1].Ingrediente.GetComponent<papaCruda>() ||
                Tablas[0].Ingrediente.GetComponent<papaCruda>() && Tablas[1].Ingrediente.GetComponent<Cuchillo>())
            {
                Cuchillo cuchillo = new Cuchillo();    
                papaCruda papaCruda = new papaCruda();
                Contruir(papaCruda, cuchillo);
                Tablas[0].Limpiar();
                Tablas[1].Limpiar();

            }
            else if(Tablas[0].Ingrediente.GetComponent<Cuchillo>() && Tablas[1].Ingrediente.GetComponent<AjiAmarillo>() ||
                Tablas[0].Ingrediente.GetComponent<AjiAmarillo>() && Tablas[1].Ingrediente.GetComponent<Cuchillo>())
            {
                Cuchillo cuchillo = new Cuchillo();
                AjiAmarillo ajiAmarillo = new AjiAmarillo();
                Contruir(ajiAmarillo, cuchillo);
                Tablas[0].Limpiar();
                Tablas[1].Limpiar();
            }
            else if (Tablas[0].Ingrediente.GetComponent<Tomate>() && Tablas[1].Ingrediente.GetComponent<Cuchillo>() ||
                Tablas[0].Ingrediente.GetComponent<Cuchillo>() && Tablas[1].Ingrediente.GetComponent<Tomate>())
            {
                Cuchillo cuchillo = new Cuchillo();
                Tomate tomate = new Tomate();
                Contruir(tomate, cuchillo);
                Tablas[0].Limpiar();
                Tablas[1].Limpiar();
            }
            else
            {
                Tablas[0].Limpiar();
                Tablas[1].Limpiar();
                print("gaa");
            }
        }
    }
    
    void Contruir(papaCruda papaCruda,Cuchillo cuchillo)
    {
        if (IngredientesEchos[0] == false)
        {
            Generadores[0].SetActive(true);
        }
        else
        {
            print("Ya Esta Creado");
        }
    }
    void Contruir(Cuchillo cuchillo, Cebolla cebolla)
    {
        if (IngredientesEchos[1] == false)
        {
            Generadores[1].SetActive(true);
        }
        else
        {
            print("No Se Contruyo Manco");
        }
    }
    void Contruir(AjiAmarillo ajiAmarillo, Cuchillo cuchillo)
    {
        if (IngredientesEchos[2] == false)
        {
            Generadores[2].SetActive(true);
        }
        else
        {
            print("No Se Contruyo Manco");
        }
    }
    void Contruir(Tomate tomate, Cuchillo cuchillo)
    {
        if (IngredientesEchos[3] == false)
        {
            Generadores[3].SetActive(true);
        }
        else
        {
            print("No Se Contruyo Manco");
        }
    }

}
