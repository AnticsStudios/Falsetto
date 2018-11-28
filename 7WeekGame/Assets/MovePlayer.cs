using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public int playerSpeed = 5;
    private float moveX;
    private float moveY;

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        PlayerRaycast();
    }

    void PlayerMove()
    {
        //Controls
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        //Animations

        if (Input.GetButtonDown("Jump"))
        {
            //attacks can go here 
        }

        //Physics for game object, makes it move on X & Y 
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, moveY * playerSpeed);
    }

    void Jump()
    {



    }



    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {


        }
    }
    void PlayerRaycast()
    {
        //Debug.DrawLine(transform.position, Vector2.down);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);
        if (hit.distance <= 1.0f && hit.collider.tag == "Enemy")
        {
            //collsion code goes here
        }
    }
}
