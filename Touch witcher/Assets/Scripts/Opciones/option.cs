using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option : MonoBehaviour
{
    [SerializeField] private GameObject Opt;
    [SerializeField] private GameObject Offpt;

    private bool isOptActive = false;

    public void Opts()
    {
        isOptActive = !isOptActive;
        Opt.SetActive(isOptActive);
        Offpt.SetActive(!isOptActive);
    }

    
    public void offpts(){
        isOptActive = !isOptActive;
        Opt.SetActive(isOptActive);
        Offpt.SetActive(!isOptActive);
    }
}