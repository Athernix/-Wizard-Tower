using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaOpciones : MonoBehaviour
{
  public ControladorOpciones panelOpciones;
 void Start(){
   panelOpciones = GameObject.FindGameObjectWithTag("Opciones").GetComponent<ControladorOpciones>(); 
  }
  void  Update(){
    if(Input.GetKeyDown(KeyCode.Escape)){
        MostrarOpciones();
    }
  }
  public void MostrarOpciones(){
    panelOpciones.pantallaOpciones.SetActive(true);
  }
}
