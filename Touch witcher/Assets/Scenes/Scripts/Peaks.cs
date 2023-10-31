using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Peaks : MonoBehaviour

{
    public Barra_vida barra_Vida;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            TakeDamage(25);
            
            //GameManager.Instance.Ta
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

