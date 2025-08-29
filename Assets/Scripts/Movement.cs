using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{

    public float xSpeed = 0.5f;
    public float ySpeed = 0.5f;
    public float zSpeed = 0.5f;

    void Start()
    {

    }


    void Update()
    {
       Move(); 
       Rotate();
    }
    void Move()
    {
        if(Input.GetKey(KeyCode.D)){


                transform.position +=new Vector3(xSpeed,0,0);

        }
          if(Input.GetKey(KeyCode.A)){
            MoveLeft();

        }
         if(Input.GetKey(KeyCode.W)){

        //to change the position of the object
        MoveUp();

        }
          if(Input.GetKey(KeyCode.S)){
            MoveDown();

        }
         if(Input.GetKey(KeyCode.Z)){

        //to change the position of the object
                transform.position +=new Vector3(0,0,zSpeed);

        }
          if(Input.GetKey(KeyCode.X)){

                transform.position -=new Vector3(0,0,zSpeed);

        }
    }
   void Rotate(){
    if (Input.GetKey(KeyCode.J))
{
    transform.Rotate(Vector3.right * xSpeed * Time.deltaTime); // Rotate around X axis
}
if (Input.GetKey(KeyCode.L))
{
    transform.Rotate(Vector3.left * xSpeed * Time.deltaTime); // Rotate around X axis
}
if (Input.GetKey(KeyCode.I))
{
    transform.Rotate(Vector3.up * ySpeed * Time.deltaTime); // Rotate around Y axis
}
if (Input.GetKey(KeyCode.K))
{
    transform.Rotate(Vector3.down * ySpeed * Time.deltaTime); // Rotate around Y axis
}


    }
    public void MoveLeft(){

            transform.position -=new Vector3(xSpeed,0,0);
    }
    public void MoveRight(){
            transform.position +=new Vector3(xSpeed,0,0);
    }
    public void MoveUp(){
        transform.position +=new Vector3(0,ySpeed,0);
    }
    public void MoveDown()
    {
    transform.position -=new Vector3(0,ySpeed,0);
    }
}
