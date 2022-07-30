using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClick : MonoBehaviour 
{
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void OnMouseOver()
    {
        anim.SetBool("Over", true);
        Debug.Log("DZIALA");
    }

   public void OnMouseExit()
    {
        anim.SetBool("Over", false);
    }

    public void OnMouseDown()
    {
        anim.SetBool("Clicked", true);


        //Ending();
        
    }

    
}

