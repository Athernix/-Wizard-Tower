using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mov_obs : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] String Direccion;
    private Vector3 j;
     public Barra_vida barra_Vida;
    void Awake()
    {
        j = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (Direccion.Equals("Right")) { transform.Translate(Vector2.right * speed * Time.deltaTime); }
        else if (Direccion.Equals("Left")) { transform.Translate(Vector2.left * speed * Time.deltaTime); }
        else if (Direccion.Equals("Down")) { transform.Translate(Vector2.down * speed * Time.deltaTime); }
        else if (Direccion.Equals("Up")) { transform.Translate(Vector2.up * speed * Time.deltaTime); }
     }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            TakeDamage(25);
        }
        else if (other.gameObject.CompareTag("Pared"))
        {
            transform.position = j;
        }
    
    }//no me acurdo como era el codigo XD
    void TakeDamage(int damage)
    {
        GameManager.Instance.currentHealth -= damage;
        barra_Vida.SetHealth(GameManager.Instance.currentHealth);
        if (GameManager.Instance.currentHealth == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
    

}
