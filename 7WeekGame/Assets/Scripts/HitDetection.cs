using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitDetection : MonoBehaviour
{


    public AudioClip Death;
    public AudioClip Wall;
    public Animator anim;
    public GameObject Player;
    public GameObject[] Projectile1;
    public GameObject[] Projectile2;
    public GameObject[] Projectile3;

    public GameObject[] ostrongGlass;
    public GameObject[] omediumGlass;
    public GameObject[] oweakGlass;

    public GameObject[] ostrongBomb;
    public GameObject[] omediumBomb;
    public GameObject[] oweakBomb;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        anim = Player.GetComponent<Animator>();
    }
    void Update()
    {
        if (Projectile1 == null)
        {
            Projectile1 = GameObject.FindGameObjectsWithTag("WeakAtk");
        }
        if(anim.GetBool("Death"))
        {
            SceneManager.LoadScene("EndGame");
        }

    }




    void OnTriggerEnter2D(Collider2D other)   // If player hits Heavy glass they Die
    {

        if (this.gameObject.tag == "Player")
        {
            if (other.gameObject.tag == "death")
            {
                anim.SetBool("Death", true);
                anim.GetComponent<Rigidbody2D>().gravityScale = 1;// (int)9.8;
            }
        }
            if (this.gameObject.tag == "Player")
            {
            if (other.gameObject.tag == "Glass1" || other.gameObject.tag == "Glass2" || other.gameObject.tag == "Glass3")
            {
                anim.SetBool("Death", true);
                anim.GetComponent<Rigidbody2D>().gravityScale = 1;// (int)9.8;
            }
            if(other.gameObject.tag == "Bomb1" || other.gameObject.tag == "Bomb2" || other.gameObject.tag == "Bomb3")
            {
                anim.SetBool("Death", true);
                Animator bomb = other.GetComponent<Animator>();
                anim.GetComponent<Rigidbody2D>().gravityScale = 1;// (int)9.8;
                bomb.SetBool("Bomb", true);

            }
        }
        if (other.gameObject.tag == "Glass1")
        {
            if (this.gameObject.tag == "WeakAtk")
            {
                Animator glass = other.GetComponent<Animator>();
                glass.SetBool("isIdle", false);
                Destroy(this.gameObject);
                
            }
            else if ((this.gameObject.tag == "MediumAtk" || this.gameObject.tag == "StrongAtk"))
            {
                Destroy(this.gameObject);
            }
        }
        if (other.gameObject.tag == "Glass2")
        {
            if (this.gameObject.tag == "MediumAtk")
            {
                Animator glass = other.GetComponent<Animator>();
                glass.SetBool("isIdle", false);
                Destroy(this.gameObject);
                
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
                Animator glass = other.GetComponent<Animator>();
                glass.SetBool("isIdle", false);
                Destroy(this.gameObject);
               
            }
            else if ((this.gameObject.tag == "MediumAtk" || this.gameObject.tag == "WeakAtk"))
            {
                Destroy(this.gameObject);
            }
        }

        if (other.gameObject.tag == "Bomb1" || other.gameObject.tag == "Bomb2" || other.gameObject.tag == "Bomb3")
        {
            if (this.gameObject.tag == "Player")
            {

                anim.SetBool("Death", true);
                anim.GetComponent<Rigidbody2D>().gravityScale = 1;// (int)9.8;

            }
        }
        if (other.gameObject.tag == "Bomb1")
        {
            if (this.gameObject.tag == "WeakAtk")
            {
                Animator bomb = other.GetComponent<Animator>();
                bomb.SetBool("Bomb", true);
            }
            else if ((this.gameObject.tag == "MediumAtk" || this.gameObject.tag == "StrongAtk"))
            {
                Destroy(this.gameObject);
                Animator bomb = other.GetComponent<Animator>();
                bomb.SetBool("Bomb", true);
            }
        }
        if (other.gameObject.tag == "Bomb2")
        {
            if (this.gameObject.tag == "MediumAtk")
            {
                Animator bomb = other.GetComponent<Animator>();
                bomb.SetBool("Bomb", true);
            }
            else if ((this.gameObject.tag == "WeakAtk" || this.gameObject.tag == "StrongAtk"))
            {
                Destroy(this.gameObject);
                Animator bomb = other.GetComponent<Animator>();
                bomb.SetBool("Bomb", true);
            }
        }
        if (other.gameObject.tag == "Bomb3")
        {
            if (this.gameObject.tag == "StrongAtk")
            {
                Animator bomb = other.GetComponent<Animator>();
                bomb.SetBool("Bomb", true);

            }
            else if ((this.gameObject.tag == "MediumAtk" || this.gameObject.tag == "WeakAtk"))
            {
                Destroy(this.gameObject);
                Animator bomb = other.GetComponent<Animator>();
                bomb.SetBool("Bomb", true);
            }
        }



    }

}