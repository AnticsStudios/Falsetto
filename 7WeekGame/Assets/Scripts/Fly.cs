using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour {

    public float upForce;                   //Upward force of the "flap".
    private bool isDead = false;            //Has the player collided with a wall?

    private Rigidbody rb;               //Holds a reference to the Rigidbody2D component of the bird.

    void Start()
    {
        //Get and store a reference to the Rigidbody2D attached to this GameObject.
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Don't allow control if the bird has died.
        if (isDead == false)
        {
            //Look for input to trigger a "flap".
            if (Input.GetMouseButtonDown(0))
            {
                //...zero out the birds current y velocity before...
                rb.velocity = Vector2.zero;
                //  new Vector2(rb2d.velocity.x, 0);
                //..giving the bird some upward force.
                rb.AddForce(new Vector2(0, upForce));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // Zero out the bird's velocity
        rb.velocity = Vector2.zero;
        // If the bird collides with something set it to dead...
        isDead = true;

    }
}
