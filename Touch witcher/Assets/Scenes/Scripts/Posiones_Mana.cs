using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posiones_Mana : MonoBehaviour
{
      
       private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player")){
           GameManager.Instance.recuperar_Mana();
           Destroy(this.gameObject);
        }
       }
}
