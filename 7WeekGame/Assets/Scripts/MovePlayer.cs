using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public int playerSpeed = 5;
    private float moveX;
    private float moveY;
    public bool facingRight = true;
    // Update is called once per frame
    void Update()
    {
        PlayerMove();
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
        if (moveX > 0.0f && facingRight == false)
        {
            FlipPlayer();
        }

        else if (moveX < 0.0f && facingRight == true)
        {

            FlipPlayer();
        }
        //Physics for game object, makes it move on X & Y 
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, moveY * playerSpeed);
    }


    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

}
