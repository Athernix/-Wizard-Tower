using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Mov_obs : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] String Direccion;
    private Vector3 j;
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

    private void OnTriggerEnter2D (Collider2D collider2D)
    {
        if (collider2D.CompareTag("Player"))
        {
            //GameManager.Instance.Perder_Vida();
            Debug.Log("-1 vida");
        }
        else if (collider2D.CompareTag("Pared")) 
        {
            transform.position = j;
        }
    }

}
