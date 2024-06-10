using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public GameObject Nube;
    public EfectoTexto Texto;
    public GameObject NubeCuy;
    public void Dialogo(sbyte n)
    {
        Nube.SetActive(true);
        if (n == 0)
        {
            Texto.Inprimir("Otro día sin clientes…Supongo que se acabó");
        }
        if (n == 1)
        {
            Texto.Inprimir("¿Y tú quién eres?");
        }
        if (n == 3)
        {
            Texto.Inprimir("Creo que me ha hecho mal no dormir bien. ¿Estoy soñando?");
        }
        if (n==5)
        {
            Texto.Inprimir("Okey? Y que tengo que hacer?");
        }
        if (n==7)
        {
            Texto.Inprimir("Entonces de verdad eres un dios para saber todo eso");
        }
        NubeCuy.SetActive(false);
    }
}
