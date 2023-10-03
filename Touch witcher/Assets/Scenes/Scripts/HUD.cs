using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class HUD : MonoBehaviour
{   
   public GameMenu opciones;
   public TextMeshProUGUI puntos;
   public   GameObject[] vidas;
   public   GameObject[] mana;
   void Update(){
    puntos.text = GameManager.Instance.puntos_totales.ToString();
   }
   public void Actualizar_Puntos(int Puntos_Totales){
      puntos.text = Puntos_Totales.ToString();
   }
   //Vida
   public void Desactivar_Vidas(int indice) {
		vidas[indice].SetActive(false);
	}
   public void  Activar_Vidas(int indice){
      vidas[indice].SetActive(true);
   }
   //Mana
   public void Desactivar_Mana(int indice){
      mana[indice].SetActive(false);
   }
   public void  Activar_Mana(int indice){
      mana[indice].SetActive(true);
   }
//Opciones
[SerializeField] private GameObject boton_Opciones;
[SerializeField] private GameObject Opciones_Menu;

[SerializeField] private GameObject Menu;
public void Opciones(){
Time.timeScale = 0f;
boton_Opciones.SetActive(false);
Menu.SetActive(true);
}
public void renaudar(){
Time.timeScale = 1;
boton_Opciones.SetActive(true);
Menu.SetActive(false);
}
public void salir(){
SceneManager.LoadScene(0);
}   
}
