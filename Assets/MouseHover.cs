using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void OnMouseOver()
    {
        anim.SetBool("Over", true);
        
    }

    public void OnMouseExit()
    {
        anim.SetBool("Over", false);
    }
}

