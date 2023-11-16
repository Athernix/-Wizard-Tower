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
    private Vector3 posicion;
    public Barra_vida barra_Vida;
    private Transform player;
    

    private void Awake()
    {
        
        
        posicion = this.gameObject.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        Movimiento(Direccion);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            TakeDamage(25);
        }
        if (other.gameObject.CompareTag("llegada"))
        {
            transform.position = posicion;
        }


    }
    void TakeDamage(int damage)
    {
        GameManager.Instance.currentHealth -= damage;
        barra_Vida.SetHealth(GameManager.Instance.currentHealth);
        if (GameManager.Instance.currentHealth == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
    private void Movimiento(string Direct)
    {
        if (Direct.Equals("Right")) { transform.Translate(Vector2.right * speed * Time.deltaTime); }
        else if (Direct.Equals("Left")) { transform.Translate(Vector2.left * speed * Time.deltaTime); }
        else if (Direct.Equals("Down")) { transform.Translate(Vector2.down * speed * Time.deltaTime); }
        else if (Direct.Equals("Up")) { transform.Translate(Vector2.up * speed * Time.deltaTime); }
    }
    

}
