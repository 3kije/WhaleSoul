using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{

    public Vector2 followSpot;
    public float speed;
    public float perspectiveScale;
    public float scaleRatio;

    private NavMeshAgent agent;
    public Animator animator;

    private Vector2 stuckDistanceCheck;

    private SpriteRenderer spriteRenderer;

    public bool inDialog;

    // Start is called before the first frame update
    void Start()
    {
        followSpot = transform.position;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!inDialog)
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Input.GetMouseButtonDown(0))
            {
                followSpot = new Vector2(mousePosition.x, mousePosition.y);
            }
            agent.SetDestination(new Vector3(followSpot.x, followSpot.y, transform.position.z));
            UpdateAnimation();
        }

        AdjustSortingLayer();
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

    private void UpdateAnimation()
    {
        float distance = Vector2.Distance(transform.position, followSpot);
        if(Vector2.Distance(stuckDistanceCheck, transform.position)==0) { animator.SetFloat("Distance", 0f); return; }

        animator.SetFloat("Distance", distance);
        if (distance > 0.01)
        {
            Vector3 direction = transform.position - new Vector3(followSpot.x, followSpot.y, transform.position.z);
            float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
            animator.SetFloat("angle", angle);
            stuckDistanceCheck = transform.position;
        }
    }

    private void AdjustSortingLayer()
    {
        spriteRenderer.sortingOrder = (int)transform.position.y * -100;
    }

        public void ExitDialog()
    {
        inDialog = false;

    }
}
