using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMovement : MonoBehaviour
{
    float mousePosx;
    float mousePosy;
    [SerializeField] float moveBackground;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosx = Input.mousePosition.x;
        mousePosy = Input.mousePosition.y;
        this.GetComponent<RectTransform>().position = new Vector2(
         (mousePosx / Screen.width) * moveBackground + (Screen.width / 2),
         (mousePosy / Screen.height) * moveBackground + (Screen.height / 2));
            
    }
}
