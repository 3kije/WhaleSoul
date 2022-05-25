using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowFall : MonoBehaviour
{
    public Animator animator;
    public Transform target;
    public float speed;

    
    // Start is called before the first frame update
    void Start()
    {
     
        enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(FallCoroutine());

    }

    IEnumerator FallCoroutine()
    {
        animator.SetBool("IsFalling", true);
        yield return new WaitForSeconds(0.6f);
        Fall();

    }


    public void Fall()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * speed);
        
    }
}
