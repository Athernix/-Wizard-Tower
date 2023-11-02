using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Peaks : MonoBehaviour
{
    public Barra_vida barra_Vida;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Comprueba si el objeto que está colisionando está en la misma capa que el jugador
        if (other.gameObject.layer == GameManager.Instance.playerLayer)
        {
            // Causa daño al jugador
            TakeDamage(25);
        }
    }

    void TakeDamage(int damage){
        GameManager.Instance.currentHealth -= damage;
        barra_Vida.SetHealth(GameManager.Instance.currentHealth);
        if (GameManager.Instance.currentHealth == 0){
            SceneManager.LoadScene(1);
        }
    }
}