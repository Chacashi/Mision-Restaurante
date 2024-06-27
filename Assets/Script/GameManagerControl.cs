using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class GameManagerControl : MonoBehaviour
{
    [HeaderAttribute("Hornillas")]
    public TablaControl[] Hornillas=new TablaControl[4];

    [HeaderAttribute("Mesas")]
    public TablaControl[] Mesas=new TablaControl[4];

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
        Crafteo(Mesas, "Cuchillo", "PapaCruda", 0);
        Crafteo(Mesas, "Cuchillo", "Cebolla", 2);
        Crafteo(Mesas, "Cuchillo", "Aji amarillo", 3);
        Crafteo(Mesas, "Cuchillo", "Tomate", 4);
        Crafteo(Mesas, "Cuchillo", "Lomo fino crudo", 5);
        
        //Hornillas
        Crafteo(Hornillas, "Fondo oscuro carne", "Guarnicion aromatica", 1);
        Crafteo(Hornillas, "Arroz", "Olla", 6);
        Crafteo(Hornillas, "Papa en bastones", "Sarten", 7);

        Crafteo(Hornillas, "Lomo fino en pedazos", "aji amarrillo en juliana", "Tomate en juliana", "cebolla en gajos", 8);

    }
    //Crafteos de 2
    void Crafteo(TablaControl[] tablas, string IngredienteA, string IngredienteB, sbyte Index)
    {
        for (int i = 0; i < tablas.Length; ++i)
        {
            for (int j = 0; j < tablas.Length; ++j)
            {
                if (tablas[i].Ingrediente != null && tablas[j].Ingrediente != null &&
                    tablas[i].Ingrediente.gameObject.tag == IngredienteA && tablas[j].Ingrediente.gameObject.tag == IngredienteB)
                {
                    Crear(tablas[i], tablas[j],Index);
                }
            }
        }
    }
    //Crafteos de 3
    void Crafteo(TablaControl a, TablaControl b, TablaControl c, TablaControl d, string IngredienteA, string IngredienteB, string IngredienteC, sbyte Index)
    {
        TablaControl[] tablas = new TablaControl[] { a, b, c, d };

        for (int i = 0; i < tablas.Length - 2; ++i)
        {
            for (int j = i + 1; j < tablas.Length - 1; ++j)
            {
                for (int k = j + 1; k < tablas.Length; ++k)
                {
                    Crear(tablas[i],tablas[j],tablas[k],Index);
                }
            }
        }
    }
    //Crafteos de 4
    void Crafteo(TablaControl[] tablas , string IngredienteA, string IngredienteB, string IngredienteC, string IngredienteD,sbyte Index)
    {
        for (int i = 0; i < tablas.Length; ++i)
        {
            for (int j = 0; j < tablas.Length; ++j)
            {
                for (int k = 0; k < tablas.Length; ++k)
                {
                    for (int l = 0; l < tablas.Length; ++l)
                    {
                        if (tablas[i].Ingrediente != null && tablas[j].Ingrediente != null && tablas[k].Ingrediente != null &&tablas[l].Ingrediente != null &&
                           (tablas[i].Ingrediente.gameObject.tag == IngredienteA && tablas[j].Ingrediente.gameObject.tag == IngredienteB &&
                           tablas[k].Ingrediente.gameObject.tag== IngredienteC && tablas[l].Ingrediente.gameObject.tag== IngredienteD))
                        {
                            Crear(tablas[i],tablas[j], tablas[k], tablas[l],Index);
                        }else if (tablas[0].Ingrediente != null && tablas[1].Ingrediente != null && tablas[2].Ingrediente != null && tablas[3].Ingrediente != null)
                        {
                            tablas[0].Limpiar();
                            tablas[1].Limpiar();
                            tablas[2].Limpiar();
                            tablas[3].Limpiar();
                        }
                    }
                }
            }
        }
    }
    void Crear(TablaControl a, TablaControl b,sbyte Index)
    {
        if (QuantityIngredientes[Index] == false)
        {
            QuantityIngredientes[Index] = true;
            Ingrediente[Index].SetActive(true);
            a.Limpiar();
            b.Limpiar();
        }
        else
        {
            a.Limpiar();
            b.Limpiar();
        }
    }
    void Crear(TablaControl a, TablaControl b,TablaControl c,sbyte Index)
    {
        Crear(a,b,Index);
        if (QuantityIngredientes[Index] == false)
        {
            c.Limpiar();
        }
        else
        {
            c.Limpiar();
        }
    }
    void Crear(TablaControl a,TablaControl b,TablaControl c,TablaControl d,sbyte Index)
    {
        Crear(a, b,Index);
        Crear(c,d,Index);
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
