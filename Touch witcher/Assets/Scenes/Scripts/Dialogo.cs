using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dialogo : MonoBehaviour
{
[SerializeField] private GameObject PanelActivo;
[SerializeField] private GameObject PanelDesactivado;
private void OnTriggerEnter2D(Collider2D collision){
 if(collision.CompareTag("Player"))
        {
            PanelActivo.SetActive(true);
        }
}
private void OnTriggerExit2D(Collider2D collision)
{
    if(collision.CompareTag("Player")){
            PanelDesactivado.SetActive(false);
        }
}
}
