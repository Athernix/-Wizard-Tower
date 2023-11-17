using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class fullScreen : MonoBehaviour
{
    public Toggle toggle;
    public TMP_Dropdown resolucionesDn;
    Resolution[] resoluciones;
    void Start()
    {
        if(Screen.fullScreen){
            toggle.isOn = true;
        }
        else{
            toggle.isOn = false;
        }
        RevisarResolucion();
    }
    void Update()
    {
        
    }
    public void Pc(bool Pc){
        Screen.fullScreen = Pc;
    }
    public void RevisarResolucion(){
        resoluciones = Screen.resolutions;
        resolucionesDn.ClearOptions();
      List<string> opciones = new List<string>();
        int resolucionActual = 0;
        for(int i = 0;  i<resoluciones.Length;i++){
            string opcion = resoluciones[i].width + " x " +resoluciones[i].height;
            opciones.Add(opcion);
            if(Screen.fullScreen && resoluciones[i].width == Screen.currentResolution.width && resoluciones[i].height == Screen.currentResolution.height){
                resolucionActual = i;
            }  
        }
        resolucionesDn.AddOptions(opciones);
        resolucionesDn.value = resolucionActual;
        resolucionesDn.RefreshShownValue();
    }
    public void CambiarResolucion(int indiceResolucion){
        Resolution resolucion = resoluciones[indiceResolucion];
        Screen.SetResolution(resolucion.width,resolucion.height,Screen.fullScreen);
    }

}
