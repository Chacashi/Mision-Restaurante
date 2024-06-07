using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlerNiveles : MonoBehaviour
{
    sbyte nivel=1;
    public Button Nivel1;
    public Button Nivel2;
    public Button Nivel3;
    void Awake()
    {
        
    }
    void Start()
    {
        if(nivel >= 1)
        {
            Nivel1.interactable = true;
            Nivel1.image.color = new Color(1, 1, 1, 1);
        }
        if(nivel >= 2)
        {
            Nivel2.interactable = true;
            Nivel2.image.color = new Color(1, 1, 1, 1);
        }
        if (nivel >= 3)
        {
            Nivel3.interactable = true;
            Nivel3.image.color = new Color(1, 1, 1, 1);
        }
    }
}
