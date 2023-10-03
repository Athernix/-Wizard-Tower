using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posiones_Mana : MonoBehaviour
{
      
   private void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Player"))
		{
			bool ManaRecuperado = GameManager.Instance.recuperar_Mana();
			
			if(ManaRecuperado) {
				Destroy(this.gameObject);
			}
		}
	}
}
