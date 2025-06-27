using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TablaControl : MonoBehaviour
{
    public GameObject Ingrediente;
    public MisionControl misionControl;
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
        if (misionControl != null)
        {
            misionControl.NotificarIngrediente(Ingrediente);
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
