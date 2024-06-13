using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken : Animal
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


    public override float SetForce()
    {
        jumpForce = 1500;
        return JumpForce;
    }


  


}
