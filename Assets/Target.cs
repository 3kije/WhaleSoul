using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{

    private Vector2 followSpot;
    public float speed;
    public float perspectiveScale;
    public float scaleRatio;

    private NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        followSpot = transform.position;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            followSpot = new Vector2(mousePosition.x, mousePosition.y);
        }
        agent.SetDestination(new Vector3(followSpot.x, followSpot.y, transform.position.z));
        //transform.position = Vector2.MoveTowards(transform.position, followSpot, Time.deltaTime * speed);
       // AdjustPerspective();
    }
    

    private void AdjustPerspective()
    {
        Vector3 scale = transform.localScale;
        scale.x = perspectiveScale * (scaleRatio - transform.position.y);
        scale.y = perspectiveScale * (scaleRatio - transform.position.y);
        transform.localScale = scale;
       // Debug.Log(perspectiveScale / transform.position.y * scaleRatio);
    }
}
