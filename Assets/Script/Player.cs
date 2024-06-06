using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text _text;
    public GameObject _nube;
    int _numdialogo = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ++_numdialogo;
            Dialogo();
        }
    }
    void Dialogo()
    {
        switch (_numdialogo)
        {
            case 1:
                _text.text = "A mi restaurante le esta llendo muy mal :(";
                break;
            case 2:
                _text.text = "Ahora quien podra ayudarme";
                break;
        }
    }
}
