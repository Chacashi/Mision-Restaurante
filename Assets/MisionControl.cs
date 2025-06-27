using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisionControl : MonoBehaviour
{
    public string ingredienteRequerido = "Papas fritas"; // o el tag, o parte del nombre del prefab
    public CuyTutorial cuy;
    bool yaCompletado = false;

    public void NotificarIngrediente(GameObject ingrediente)
    {
        if (yaCompletado) return;

        // Comparación flexible por nombre (asegúrate que el prefab tenga este nombre o tag)
        if (ingrediente.name.Contains(ingredienteRequerido) || ingrediente.tag == ingredienteRequerido)
        {
            yaCompletado = true;
            cuy.ForzarDialogoFinal(); // método en tu cuy
        }
    }
}