using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public HUD hud;
    public Barra_vida barra_Vida;

    public int PuntosTotales { get; private set; }


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Cuidado! Mas de un GameManager en escena.");
        }
    }

    public void SumarPuntos(int puntosASumar)
    {
        PuntosTotales += puntosASumar;
        hud.ActualizarPuntos(PuntosTotales);
    }
    //Vida
    public int maxHealth = 100;
    public int currentHealth;

    public void Max_Healt() {
    currentHealth = maxHealth;
    barra_Vida.SetMaxHealth(maxHealth);
    }
    public void dam() {
    if(Input.GetKeyDown(KeyCode.Space)){
    TakeDamage(25);
    }
    }
    void TakeDamage(int damage){
    currentHealth -= damage;
    barra_Vida.SetHealth(currentHealth);
        if (currentHealth == 0){
            SceneManager.LoadScene(1);
        }
    }
    public int playerLayer;
}