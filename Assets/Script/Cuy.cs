using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Cuy : MonoBehaviour
{
    public Text _text;
    public GameObject _nube;
    public float Speed;
    Rigidbody2D _rigidbody2D;
    int _numdialogo = 0;
    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ++_numdialogo;
        } 
    }
    void FixedUpdate()
    {
        if(_numdialogo == 3)
        {
            _rigidbody2D.velocity = new Vector2(Speed * -1 , _rigidbody2D.velocity.y);
        }
    }
    void Dialogo()
    {
        switch( _numdialogo )
        {
            
        }
    }
}
