using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{


   
    private float jumpForce;


    public float JumpForce
    {
        get { return jumpForce; }
        set
        {
            jumpForce = value;
            
        }
    }






    public override void DisplayText()
    {
        Debug.Log("Hey I am Dog");
    }



   

}
