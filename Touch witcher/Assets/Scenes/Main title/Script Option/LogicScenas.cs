using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicScenas : MonoBehaviour
{
    private void  Awake()
    {
        var noDestruirEntreScenas = FindObjectsOfType<LogicScenas>();
        //if(noDestruirEntreScenas.Length > 1){
        //    Destroy(gameObject);
        //    return;
        //}
        DontDestroyOnLoad(gameObject);
    }
}
