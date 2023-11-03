using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TMain : MonoBehaviour
{
    
    public void Play(){
        SceneManager.LoadScene("Jugar");
    }
    public void Tutorial(){
        SceneManager.LoadScene("Tutorial");
    }
    public void Quit(){
        Application.Quit();
    }
}
