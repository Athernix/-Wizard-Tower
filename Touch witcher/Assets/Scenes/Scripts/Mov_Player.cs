using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class Mov_Player : MonoBehaviour
{
    [SerializeField] public int size = 16;
   [SerializeField] public int Speed = 10;
    
   public Rigidbody2D PlayerMove;

   private Vector2 moveInput; 
    void Start(){
        PlayerMove = GetComponent<Rigidbody2D>();
    }
    void Update(){   
        int Speed_T = size / Speed;
        float MoveY = Input.GetAxis("Horizontal");
        float MoveX = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(MoveY, MoveX, 0) * Speed_T * Time.deltaTime);
        
    }
    

    
}
