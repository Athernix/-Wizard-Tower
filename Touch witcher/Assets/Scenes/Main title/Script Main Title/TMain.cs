using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TMain : MonoBehaviour
{
    
    public void Play(){
        SceneManager.LoadScene("jugar", LoadSceneMode.Single);
    }
    public void Tutorial(){
        SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
    }
    public void Quit(){
        Application.Quit();
    }
}
