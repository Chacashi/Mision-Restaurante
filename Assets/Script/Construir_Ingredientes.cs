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
            if (Tablas[0].Ingrediente.gameObject.name == "cuchillo" && Tablas[1].Ingrediente.gameObject.name=="cebolla")
            {  
                Tablas[0].Limpiar();
                Tablas[1].Limpiar();
                print("Creado");
            }
            else
            {
                Tablas[0].Limpiar();
                Tablas[1].Limpiar();
                print("gaa");
            }
        }
    }
}
