﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isdDead;
    public int[] pitchArray;

    public float accel = 6f;
    public float speed = 6f;

    private bool isGoingUp;
    private bool isGoingDown;
    private float YeetSpeedUp = 2f;
    private float YeetSpeedDown = -2f;

    private Vector2 input;

    //Glass checks for walls
    Glass Glass1;
    Glass Glass2;
    Glass Glass3;

    private Animator animator;
    private Rigidbody2D rigidbody;

    //called when the player dies
    public void Deaderino()
    {
        isdDead = true;
    }

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();

        //Array to contain each value of the sound pitch to break different thicknesses of glass
        pitchArray = new int[3];

        pitchArray[0] = 1;
        pitchArray[1] = 2;
        pitchArray[2] = 3;

        isGoingUp = false;
        isGoingDown = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W) )
        //{
        //    rigidbody.velocity = new Vector2(0.0f, 0.0f);
        //    Debug.Log("neutral");
        //}

        if (Input.GetKey(KeyCode.W))
        {
            if (isGoingDown == true)
            {
                rigidbody.velocity = new Vector2(0.0f, 0.0f);
            }

            else

                rigidbody.velocity = new Vector2(0.0f, 2.0f);
            isGoingUp = true;

            Debug.Log("going up");
        }

        //if (Input.GetKey(KeyCode.S) && isGoingUp == true)
        //{
        //    rigidbody.velocity = new Vector2(0.0f, 0.0f);
        //    Debug.Log("neutral");
        //}

        if (Input.GetKey(KeyCode.S))
        {
            if (isGoingUp == true)
            {
                rigidbody.velocity = new Vector2(0.0f, 0.0f);
            }

            else

                rigidbody.velocity = new Vector2(0.0f, -2.0f);
            isGoingDown = true;

            Debug.Log("going down");
        }


        //Casts a ray
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);

        //If the ray hits something
        if (hit.collider != null)
        {
            float distance = Mathf.Abs(hit.point.x - transform.position.x);

            //If the distance is lower than 10 then it checks the tag and compare it with the pitchArray
            //If it matches, then it calls the function to break the glass wall
            if (distance < 10)
            {
                if (hit.collider.gameObject.tag == "Glass1")
                {
                    if (pitchArray[0] == 1)
                    {
                        Glass1.GetComponent<Glass>().Shatter();
                    }
                }
                else if (hit.collider.gameObject.tag == "Glass2")
                {
                    if (pitchArray[1] == 2)
                    {
                        Glass1.GetComponent<Glass>().Shatter();
                    }
                    if (hit.collider.gameObject.tag == "Glass3")
                    {
                        if (pitchArray[2] == 3)
                        {
                            Glass1.GetComponent<Glass>().Shatter();
                        }
                    }
                }

            }
        }
    }
}
        
 