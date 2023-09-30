using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{  
    public static GameManager Instance { get; private set; } 
    public int Puntos_Totales{get{return puntos_totales;}}
    public HUD hUD;
    private int vidas = 3;
    private int mana = 3 ;
    private int puntos_totales;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Cuidado! Mas de un GameManager en escena.");
        }
    }
    public void sumar_puntos(int puntos_a_Sumar){
        puntos_totales =+ puntos_a_Sumar;
        Debug.Log(puntos_totales);
        hUD.Actualizar_Puntos(puntos_totales);
    }
    //vida
     public void Perder_Vida(){
        vidas = vidas -1;
        if(vidas == 0){
            //IR AL MENU PRINCIPAL
            SceneManager.LoadScene(0);
        }
        hUD.Desactivar_Vidas(vidas);
     }
     //Mana
     public void Perder_Mana(){
        mana = mana -1;
        hUD.Desactivar_Mana(mana);
     }
     public void recuperar_Mana() {
		hUD.Activar_Mana(mana);
        mana += 1;
}
}