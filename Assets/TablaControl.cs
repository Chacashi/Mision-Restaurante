using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TablaControl : MonoBehaviour
{
    public GameObject Ingrediente;
    public bool Confirmar = false;
    bool Confirmado=false;

    public void Guardar(GameObject food)
    {
        if (Ingrediente == null)
        {
            
            Ingrediente = food;
        }
        else
        {
            Destroy(food);
        }
    }
    private void Update()
    {
        if(Ingrediente != null)
        {
            Confirmar = true;
        }
        else
        {
            Confirmar=false;
        }
    }
    public void Limpiar()
    {
        if (Ingrediente != null)
        {
            Destroy(Ingrediente);
            Ingrediente = null;
        }
    }
}
