using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.Playables;
 

public class ClickCount : MonoBehaviour
{
    private int clicksCountdown;
    public GameObject LampCanvas;
    public GameObject Clickable;
    public GameObject Light;
    public Animator anim;
    public Fungus.Flowchart myFlowchart;
    public PlayableDirector director;
    

    

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

        director.Play();
        Light.SetActive(false);
       
        myFlowchart.ExecuteBlock("Clickable/Lamp (Copy)");


    }

    public void Close()
    {
        Clickable.SetActive(true);
        LampCanvas.SetActive(false);
      
        Light.SetActive(true);
        //Timeline start 
        //anim.animation.Play("open", 1);




    }
}
