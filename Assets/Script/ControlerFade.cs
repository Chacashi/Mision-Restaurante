using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerFade : MonoBehaviour
{
    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void SetActiveAnimation()
    {
        animator.SetTrigger("Comenzar");
    }


}
