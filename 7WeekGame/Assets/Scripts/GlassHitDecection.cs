using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassHitDecection : MonoBehaviour
{

    public Animator anim;
    public Animator strongGlass;
    public Animator mediumGlass;
    public Animator weakGlass;
    public GameObject Player;
    public GameObject[] Projectile1;
    public GameObject[] Projectile2;
    public GameObject[] Projectile3;

    public GameObject[] ostrongGlass;
    public GameObject[] omediumGlass;
    public GameObject[] oweakGlass;


    public int glassAmount;

    void Start()
     
    {
        Player = GameObject.FindGameObjectWithTag("Player");

    }
    void Update()
    {
        Projectile1 = GameObject.FindGameObjectsWithTag("WeakAtk");
        Projectile2 = GameObject.FindGameObjectsWithTag("MediumAtk");
        Projectile3 = GameObject.FindGameObjectsWithTag("StrongAtk");
        oweakGlass = GameObject.FindGameObjectsWithTag("Glass1");
        omediumGlass = GameObject.FindGameObjectsWithTag("Glass2");
        ostrongGlass = GameObject.FindGameObjectsWithTag("Glass3");
    }

    public void doAnimations(GameObject[] animateGlass)
    {
        Animator glass = animateGlass[0].GetComponent<Animator>();
        glass.SetBool("isIdle", false);
        glass.GetComponent<BoxCollider2D>().enabled = false;
        Debug.Log("in here");
    }

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
                doAnimations(oweakGlass);
                //GetComponent<Rigidbody2D>().gravityScale = 1;
            }
            else if((this.gameObject.tag == "MediumAtk" || this.gameObject.tag == "StrongAtk"))
            {
                Destroy(this.gameObject);
            }
        }
            if (other.gameObject.tag == "Glass2")
            {
                if (this.gameObject.tag == "MediumAtk")
                {
                doAnimations(omediumGlass);
                Debug.Log("in here");

                //GetComponent<Rigidbody2D>().gravityScale = 1;
                 }
                else if ((this.gameObject.tag == "WeakAtk" || this.gameObject.tag == "StrongAtk"))
                {
                    Destroy(this.gameObject);
                }
        }
            if (other.gameObject.tag == "Glass3")
            {
                if (this.gameObject.tag == "StrongAtk")
                {
                doAnimations(ostrongGlass);
            }
            else if ((this.gameObject.tag == "MediumAtk" || this.gameObject.tag == "WeakAtk"))
            {
                Destroy(this.gameObject);
            }
        }
        


    }

}