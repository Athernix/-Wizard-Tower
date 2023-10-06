using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{  
       public static GameManager Instance { get; private set; }
    
	public HUD hUD;

    public int puntos_totales {get; private set;}

	private int vidas = 3;
    private int mana = 3 ;
   
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
        puntos_totales += puntos_a_Sumar;
        hUD.Actualizar_Puntos(puntos_totales);
    }
    //vida
     public void Perder_Vida() {
		vidas -= 1;

		if(vidas == 0)
		{
			// Reiniciamos el nivel.
			SceneManager.LoadScene(1);
		}

		hUD.Desactivar_Vidas(vidas);
	}
    //llaves
    private float llaves;

public void sumar_Llaves(int Puntos_Totales_Llaves){
    llaves += Puntos_Totales_Llaves;
hUD.Actualizar_Llaves(Puntos_Totales_Llaves);
}
}
