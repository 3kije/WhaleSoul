using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCount : MonoBehaviour
{
    private int clicksCountdown;
    public GameObject LampCanvas;
    public GameObject Light;
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {

        clicksCountdown = 3;
        anim = GetComponentInChildren<Animator>();
    }


    public void OnMouseDown()
    {

        anim.SetTrigger("Flame_blow");

        clicksCountdown -= 1;


        if (clicksCountdown < 1)
        {
            anim.SetBool("Flame_out", true);

            Ending();
        }
    }

   

    private void Ending()
    {
        anim.Play("Lamp_no_flame", 1);
        ///LampCanvas.SetActive(false);
        //Timeline start 
        //anim.animation.Play("open", 1);
       
       


    }

    public void Close()
    {
        LampCanvas.SetActive(false);
        Light.SetActive(false);
        //Timeline start 
        //anim.animation.Play("open", 1);




    }
}
