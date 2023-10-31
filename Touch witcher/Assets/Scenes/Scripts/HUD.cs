using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class HUD : MonoBehaviour{   
   public GameMenu opciones;
   public TextMeshProUGUI puntos;
   public TextMeshProUGUI llaves;
   public   GameObject[] vidas;
   //mana
   public  Image Manabar;
   public float Mymana;
   private float currentmana;
   void Start(){
      currentmana = Mymana;
   }
   void Update(){
    puntos.text = GameManager.Instance.puntos_totales.ToString();
     if(currentmana< Mymana){
         Manabar.fillAmount = Mathf.MoveTowards(Manabar.fillAmount,1f,Time.deltaTime * 0.01f);
         currentmana = Mathf.MoveTowards(currentmana/Mymana,1f,Time.deltaTime * 0.01f)* Mymana;
      }   
      if(currentmana < 0){
         currentmana = 0;
         // Corrección: comprobar si Mymana es igual a cero antes de dividir
         if (Mymana == 0) {
             Manabar.fillAmount = 0f;
         } else {
             Manabar.fillAmount = currentmana / Mymana;
         }
      }
   }
   public void Actualizar_Puntos(int Puntos_Totales){
      puntos.text = Puntos_Totales.ToString();
   }
   //Llaves
 public void Actualizar_Llaves(int Puntos_Totales_Llaves){
      llaves.text = Puntos_Totales_Llaves.ToString("0");
   }
   //Vida
   public void Desactivar_Vidas(int indice) {
		vidas[indice].SetActive(false);
	}
   public void  Activar_Vidas(int indice){
      vidas[indice].SetActive(true);
   }
   //mana
   public void reduce_mana(float mana){
         currentmana -= mana;
         // Corrección: comprobar si Mymana es igual a cero antes de dividir
         if (Mymana == 0) {
             Manabar.fillAmount = 0f;
         } else {
             Manabar.fillAmount = currentmana / Mymana;
         }
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
