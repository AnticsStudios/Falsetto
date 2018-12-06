using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigGlassScript : MonoBehaviour
{

    public Animator anim;




    //  public SpriteRenderer Charged3;  

    //  public MeshCollider chargedattack3;

    public Animator weakGlass;
    public Animator mediumGlass;
    public Animator strongGlass;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame



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
        if (other.gameObject.tag == "StrongAtk")
        {
            

            strongGlass.SetBool("StrongGlass", true);
            strongGlass.Play("StrongGlass");
            if (strongGlass.GetFloat("NewTime") == 1)
            {
                Destroy(other.gameObject);
            }
        }


    }

}


