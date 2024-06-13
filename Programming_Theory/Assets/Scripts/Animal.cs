using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    private float jumpForceDef;

    
    private void Start()
    {
        jumpForceDef = 500;
    }


    private void OnMouseDown()
    {
        AddForceUp();
        DisplayText();
    }



    public virtual void DisplayText()
    {
        Debug.Log("Hey! I am "+gameObject.name + " From Base Class");
        
    }

   public virtual void AddForceUp()
    {
        Rigidbody aa = gameObject.GetComponent<Rigidbody>();

        jumpForceDef = SetForce(); //Chicken override this function

        aa.AddForce(Vector3.up * jumpForceDef * Time.deltaTime, ForceMode.Impulse);;

    }


    public virtual float SetForce()
    {
        

        return jumpForceDef;
    }

}
