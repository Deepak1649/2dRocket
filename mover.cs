using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
   

   
    float yValue= 0;
    [SerializeField] float movespeed = 10f;
   
    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {   MovePlayer();
   
    }

    
    void PrintInstruction()
    {
        Debug.Log("welcome  to the game");
        Debug.Log("move with wasd");
        Debug.Log("DOnt hit the walls");
        
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal")* Time.deltaTime * movespeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        
        transform.Translate(xValue,yValue,zValue);
    }
}
