using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activar_obstaculos : MonoBehaviour
{
    [SerializeField] GameObject obs;
    private GameObject colision;
    private Vector3 j;
    private float v;
    // Start is called before the first frame update
    void Start()
    {
        colision = GameObject.Find("Player");
        j = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        v = Vector3.Distance(colision.gameObject.transform.position, j);
        Debug.Log(v);
        if (v < 15)
        {
            obs.gameObject.SetActive(true);

        }
        else { obs.gameObject.SetActive(false); }
        
    }

}
