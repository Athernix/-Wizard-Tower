using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Quality : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public int calidad;
    void Start(){
        calidad = PlayerPrefs.GetInt("numeroCalidad",2);
        dropdown.value = calidad ;
        AjustarC();
    }
    public void AjustarC(){
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numeroCalidad", dropdown.value);
        calidad = dropdown.value;

    }
}
