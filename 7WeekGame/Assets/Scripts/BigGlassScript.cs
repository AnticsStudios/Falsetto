using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigGlassScript : MonoBehaviour
{

    public Animator anim;

    public Animator weakGlass;
    public Animator mediumGlass;
    public Animator strongGlass;
    
    public GameObject projectile3;
    public BoxCollider2D Strong;

    public GameObject Glass;
  
    public Collision2D HasCollided;

    void Update()
    {

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame

int kill(GameObject other)
    {
        other.GetComponent<BoxCollider2D>().enabled = false;
        Destroy(other.gameObject);
        return 1;
    }


    void OnTriggerEnter2D(Collider2D other)   // If player hits Heavy glass they Die
    {
        if (this.tag == "Player")
        {
            anim.SetBool("Death", true);
        }
        if (other.gameObject.tag == "Glass")
        {
            Destroy(other.gameObject);
            GetComponent<Rigidbody2D>().gravityScale = (int)9.8;
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
        //          Glass.gameObject.GetComponent<BoxCollider2D>().enabled.Equals(false);

        //      } 
        //      strongGlass.SetBool("StrongGlass", true);
        //      strongGlass.Play("StrongGlass");
        //      Destroy(other.gameObject);


        //  }



        if (other.gameObject.tag == "StrongAtk")
        {


            strongGlass.SetBool("StrongGlass", true);
            strongGlass.Play("StrongGlass");

            {
                strongGlass.SetBool("StrongGlass", false);
                other.GetComponent<BoxCollider2D>().enabled = false;
                Destroy(other.gameObject);
            }


        }

    }

}
}



