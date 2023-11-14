using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class HUD : MonoBehaviour
{
    public TextMeshProUGUI puntos;
    public GameObject[] vidas;

    void Update()
    {
       
    }

    public void ActualizarPuntos(int puntosTotales)
    {
        puntos.text = puntosTotales.ToString();
    }
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menu_Pausa;
    public void Pausa(){
            Time.timeScale = 0f;
            botonPausa.SetActive(false);
            menu_Pausa.SetActive(true);
    }
    public void Renaudar(){
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menu_Pausa.SetActive(false);
        

    }
    public void salir(){
        SceneManager.LoadScene(0);
    }
}