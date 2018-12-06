using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombRob : MonoBehaviour
{

    public Animator anim;
    public Animator []Bomb1;
    public Animator[]Bomb2;
    public Animator[]Bomb3;

    public GameObject Player;
    public GameObject[] Projectile1;
    public GameObject[] Projectile2;
    public GameObject[] Projectile3;

    public GameObject[] ostrongBomb;
    public GameObject[] omediumBomb;
    public GameObject[] oweakBomb;


    public int bombAmount;

    void Start()

    {
        Player = GameObject.FindGameObjectWithTag("Player");

    }
    void Update()
    {
        Projectile1 = GameObject.FindGameObjectsWithTag("WeakAtk");
        Projectile2 = GameObject.FindGameObjectsWithTag("MediumAtk");
        Projectile3 = GameObject.FindGameObjectsWithTag("StrongAtk");
        oweakBomb = GameObject.FindGameObjectsWithTag("Bomb1");
        omediumBomb = GameObject.FindGameObjectsWithTag("Bomb2");
        ostrongBomb = GameObject.FindGameObjectsWithTag("Bomb3");
    }

    public void doAnimations(GameObject[] animateBomb)
    {
        Animator Bomb = animateBomb[0].GetComponent<Animator>();
        Bomb.SetBool("Bomb", false);
        Bomb.GetComponent<BoxCollider2D>().enabled = false;
        Debug.Log("in here");
    }

    void OnTriggerEnter2D(Collider2D other)   // If player hits Heavy glass they Die
    {
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
                doAnimations(oweakBomb);
                //GetComponent<Rigidbody2D>().gravityScale = 1;
            }
            else if ((this.gameObject.tag == "MediumAtk" || this.gameObject.tag == "StrongAtk"))
            {
                Destroy(this.gameObject);
            }
        }
        if (other.gameObject.tag == "Bomb2")
        {
            if (this.gameObject.tag == "MediumAtk")
            {
                doAnimations(omediumBomb);
                Debug.Log("in here");

                //GetComponent<Rigidbody2D>().gravityScale = 1;
            }
            else if ((this.gameObject.tag == "WeakAtk" || this.gameObject.tag == "StrongAtk"))
            {
                Destroy(this.gameObject);
            }
        }
        if (other.gameObject.tag == "Bomb3")
        {
            if (this.gameObject.tag == "StrongAtk")
            {
                doAnimations(ostrongBomb);
            }
            else if ((this.gameObject.tag == "MediumAtk" || this.gameObject.tag == "WeakAtk"))
            {
                Destroy(this.gameObject);
            }
        }



    }

}