using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HUD : MonoBehaviour
{   
   public GameManager gameManager;
   public TextMeshProUGUI puntos;
   public   GameObject[] vidas;
   public   GameObject[] mana;
   void Update(){
    puntos.text = gameManager.Puntos_Totales.ToString();
   }
   public void Actualizar_Puntos(int Puntos_Totales){
      puntos.text = Puntos_Totales.ToString();
   }
   //Vida
   public void  Desactivar_Vidas(int indice){
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
   
}
