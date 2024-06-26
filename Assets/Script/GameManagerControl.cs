using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerControl : MonoBehaviour
{
    [HeaderAttribute("Hornillas")]
    public TablaControl Hornilla1;
    public TablaControl Hornilla2;
    public TablaControl Hornilla3;
    public TablaControl Hornilla4;

    [HeaderAttribute("Mesas")]
    public TablaControl Mesa1;
    public TablaControl Mesa2;
    public TablaControl Mesa3;
    public TablaControl Mesa4;

    [HeaderAttribute("Ingredientes")]
    public GameObject[] Ingrediente;

    [HeaderAttribute("asdas")]
    bool[] QuantityIngredientes;
    private void Awake()
    {
        QuantityIngredientes=new bool[Ingrediente.Length];
    }
    private void Update()
    {

        //Mesa
        Crafteo(Mesa1, Mesa2, Mesa3, Mesa4, "Cuchillo", "PapaCruda", 0);
        Crafteo(Mesa1, Mesa2, Mesa3, Mesa4, "Cuchillo", "Cebolla", 2);
        Crafteo(Mesa1, Mesa2, Mesa3, Mesa4, "Cuchillo", "Aji amarillo", 3);
        Crafteo(Mesa1, Mesa2, Mesa3, Mesa4, "Cuchillo", "Tomate", 4);
        Crafteo(Mesa1, Mesa2, Mesa3, Mesa4, "Cuchillo", "Lomo fino crudo", 5);
        Crafteo(Mesa1, Mesa2, Mesa3, Mesa4, "Arroz", "Olla", 6);
        //Hornillas
        Crafteo(Hornilla1, Hornilla2, Hornilla3, Hornilla4, "Fondo oscuro carne", "Guarnicion aromatica", 1);
        Crafteo(Hornilla1, Hornilla2, Hornilla3, Hornilla4, "Papa en bastones", "Sarten", 7);

    }
    void Crafteo(TablaControl a,TablaControl b,TablaControl c,TablaControl d,string IngredienteA,string IngredienteB,sbyte Index)
    {
        Crear(a, b, IngredienteA, IngredienteB, Index);
        Crear(a, c, IngredienteA, IngredienteB, Index);
        Crear(a, d, IngredienteA, IngredienteB, Index);
        Crear(b, c, IngredienteA, IngredienteB, Index);
        Crear(b, d, IngredienteA, IngredienteB, Index);
        Crear(c, d, IngredienteA, IngredienteB, Index);
    }
    void Limpiar(TablaControl a,TablaControl b)
    {
        a.Limpiar();
        b.Limpiar();
    }
    private void Crear(TablaControl mesaA, TablaControl mesaB,string IngredenteA,string IngredenteB,sbyte Index)
    {
        if (mesaA != null && mesaB != null && mesaA.Confirmar && mesaB.Confirmar)
        {
            if (mesaA.Ingrediente != null && mesaB.Ingrediente != null &&
                ((mesaA.Ingrediente.gameObject.tag == IngredenteA && mesaB.Ingrediente.gameObject.tag == IngredenteB) ||
                 (mesaB.Ingrediente.gameObject.tag == IngredenteA && mesaA.Ingrediente.gameObject.tag == IngredenteB)))
            {
                if (QuantityIngredientes[Index]==false)
                {
                    Limpiar(mesaA, mesaB);
                    QuantityIngredientes[Index] = true;
                    Ingrediente[Index].SetActive(true);
                }
                else
                {
                    Limpiar(mesaA, mesaB);
                }
            }
        }
    }
    void ReiniciarCocina()
    {
        for(int i = 0;i<QuantityIngredientes.Length;++i)
        {
            QuantityIngredientes [i] = false;
            Ingrediente[i].SetActive(false);
        }
    }
}
