using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TMain : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cargarscena(){
        SceneManager.LoadScene("Play");
    }
    public void cargar(string Option){
        SceneManager.LoadScene(Option);
    }
    public void quit(){
        Application.Quit();
    }
}
