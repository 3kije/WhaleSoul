using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCount : MonoBehaviour
{
    private int clicksCountdown;
    public GameObject LampCanvas;
    public GameObject Light;


    // Start is called before the first frame update
    void Start()
    {

        clicksCountdown = 3;

    }


    public void OnMouseDown()
    {


        clicksCountdown -= 1;


        if (clicksCountdown < 1)
        {
            Ending();
        }
    }

   

    private void Ending()
    {
        LampCanvas.SetActive(false);
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
