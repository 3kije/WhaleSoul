using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed = 10f;
    bool facingRight = true;

    Rigidbody rb2d;

    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.5f;
    public LayerMask whatIsGround;
    public float jumpForce = 700f;


    // Update is called once per frame
    void FixedUpdate()
    {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        float move = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }

    void Update()
    {
        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {

            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }


    }

    void Flip()

    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}