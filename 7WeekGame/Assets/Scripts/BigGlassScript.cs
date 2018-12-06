using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigGlassScript : MonoBehaviour
{
    public Animator anim;

    public GameObject weakGlass;
    public Animator mediumGlass;
    private GameObject strongGlass;

    public GameObject Attack3;
    public CollisionDetectionMode CollisionDetection;

    public Rigidbody2D Projectile;
    public Collider2D Glass;


    // Update is called once per frame


    void OnTriggerEnter2D(Collider2D other)   // If player hits Heavy glass they Die
    {
        if (anim)
        {
            anim.SetBool("Death", true);
            GetComponent<Rigidbody2D>().gravityScale = (int)9.8;
        }

        if (other.gameObject.tag == "Clone")
        {


        }

        if (other.gameObject.tag == "StrongAtk")
        {
            //     strongGlass.SetBool("StrongGlass", true);
            other.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Rigidbody2D>().gravityScale = (int)9.8;
            other.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            Destroy(other.gameObject);
        }



        //if (this.tag == "WeakAtk")
        //{
        //    weakGlass.SetBool("", true);

        //}
        //if (this.tag == "MediumAtk")
        //{
        //    mediumGlass.SetBool("", true);

        //}
        //  if (HasCollided.gameObject == true)
        //  {
        //      ((Strong.GetComponent<Destroy>().enabled.Equals(true)

        //  if (strongGlass.gameObject.tag == "Glass" && (HasCollided.gameObject.tag == "projectile3"))
        //  {

        //if (Strong.GetComponent<Destroy>().enabled == true)
        //      {
        //          strongGlass.SetBool("StrongGlass", true);
        //          strongGlass.Play("StrongGlass");
        //          

        //      } 
        //      strongGlass.SetBool("StrongGlass", true);
        //      strongGlass.Play("StrongGlass");
        //      Destroy(other.gameObject);


        //  }




    }

}



