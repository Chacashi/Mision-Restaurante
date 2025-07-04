using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelInfo : MonoBehaviour
{
    public GameObject panel;
    public void Awake()
    {
        panel.SetActive(false);
    }
    public void Info()
    {
        panel.SetActive(true);
    }
    public void ExitPanel()
    {
        panel.SetActive(false);
    }
}
