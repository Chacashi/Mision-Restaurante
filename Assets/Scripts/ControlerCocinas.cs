using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ControlerCocinas : MonoBehaviour
{
    Button _boton;
    public GameObject[] Cocinas;
    public GameObject Sale;
    sbyte index = 0;
    private void Awake()
    {
        _boton = GetComponent<Button>();
        _boton.onClick.AddListener(() => Cuando_Cliqueo());
    }
    void Cuando_Cliqueo()
    {
        Cocinas[0].SetActive(true);
        Sale.SetActive(false);  
    }
    public void Value()
    {
    }
}
