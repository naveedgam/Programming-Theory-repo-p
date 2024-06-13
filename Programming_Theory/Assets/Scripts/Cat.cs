using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
   

    private float jumpForce;

    // Public property
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
        Debug.Log("Hey I am Cat");
    }



    
}
