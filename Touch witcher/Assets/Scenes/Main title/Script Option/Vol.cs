using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vol : MonoBehaviour

{
    public Slider slider;
    public float sliderValue;
    public Image imageMute;
    void Start(){
        sliderValue = PlayerPrefs.GetFloat("VolumenAudio",0.5f);
        AudioListener.volume = slider.value;
        MuteR ();
    }
    public void ChangeSlider(float valor){
        sliderValue = valor;
        PlayerPrefs.SetFloat("VolumenAudio",sliderValue);
        AudioListener.volume = slider.value ;
        MuteR();
    }
    public void MuteR (){
        if (sliderValue == 0){
            imageMute.enabled = true;
        }
        else
        {
            imageMute.enabled = false ;
        }

    }
}
