using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CambioScene : MonoBehaviour
{
    float Tiempo=1;
    float TiempoIncial=0;
    bool Comenzar;
    string scene;
    public void LoadScene(string sceneName,float Tiempo)
    {
        this.Tiempo = Tiempo;
        Comenzar = true;
        scene = sceneName;
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    private void Update()
    {
        if (Comenzar == true)
        {
            TiempoIncial += Time.deltaTime;
        }
        if (Tiempo <= TiempoIncial)
        {
            SceneManager.LoadScene(scene);
        }
    }

}
