using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.Playables;

public class doorTimeline : MonoBehaviour

{

    public Fungus.Flowchart myFlowchart;
    public PlayableDirector director;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TimelineStart()
    {
        director.Play();
    }
}
