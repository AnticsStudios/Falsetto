using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassHitDecection : MonoBehaviour
{

    public Animator anim;
    public Animator Projectile1;
    public Animator Projectile2;
    public Animator Projectile3;

    public Animator strongGlass;
    public Animator mediumGlass;
    public Animator weakGlass;
    void OnTriggerEnter2D(Collider2D other)   // If player hits Heavy glass they Die
    {
        if (other.gameObject.tag == "Glass1"|| other.gameObject.tag == "Glass2"|| other.gameObject.tag == "Glass3")
        {
            if (this.gameObject.tag == "Player")
            {
                anim.SetBool("Death", true);
                anim.GetComponent<Rigidbody2D>().gravityScale = 1;// (int)9.8;
            }
        }
        if (other.gameObject.tag == "Glass1")
        {
            if (this.gameObject.tag == "WeakAtk")
            {
                //Debug.Log("in here");
                weakGlass.SetBool("isIdle", false);
                weakGlass.GetComponent<BoxCollider2D>().enabled = false;
                //GetComponent<Rigidbody2D>().gravityScale = 1;
            }
        }
            if (other.gameObject.tag == "Glass2")
            {
                if (this.gameObject.tag == "MediumAtk")
                {
                    //Debug.Log("in here");
                    mediumGlass.SetBool("isIdle", false);
                    mediumGlass.GetComponent<BoxCollider2D>().enabled = false;
                    //GetComponent<Rigidbody2D>().gravityScale = 1;
                }
            }
            if (other.gameObject.tag == "Glass3")
            {
                if (this.gameObject.tag == "StrongAtk")
                {
                    //Debug.Log("in here");
                    strongGlass.SetBool("isIdle", false);
                    strongGlass.GetComponent<BoxCollider2D>().enabled = false;
                    //GetComponent<Rigidbody2D>().gravityScale = 1;
                }
            }
        


    }
}