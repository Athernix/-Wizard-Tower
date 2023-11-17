using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicScenas : MonoBehaviour
{
    private void  Awake()
    {
        var noDestruirEntreScenas = FindObjectOfType<LogicScenas>();
        if(noDestruirEntreScenas){
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
}
