using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerBarrido : MonoBehaviour
{
    Animator animator;
    bool _static;
    public bool _Entrada;
    bool _Salida;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Start()
    {
        if(_Entrada == true)
        {
            animator.SetTrigger("Entrada");
        }
    }
}
