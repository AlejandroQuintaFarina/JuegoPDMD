using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cargarEscena : MonoBehaviour
{
    public String nombreEscena = "escena2";
    void Start()
    {
        SceneManager.LoadScene(nombreEscena);
    }
    void Update()
    {
        
    }
}
