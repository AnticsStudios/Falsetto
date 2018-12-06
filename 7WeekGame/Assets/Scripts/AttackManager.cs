﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour {
    Animator anim;
    public Animator projectile1;
    public Animator projectile2;
    public Animator projectile3;
    public GameObject Charged1;
    public GameObject Charged2;
    public GameObject Charged3;
    public Transform ActualPlayer;
    public Transform Launcher;
    public bool isAttacking = false;
    public float projectileSpeed = 0.1f;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
    }


    GameObject FireBullets(GameObject name)
    {

        GameObject ChargedUpShot = Instantiate(name) as GameObject;
        return ChargedUpShot;

    }


    // Update is called once per frame
    void Update ()
    {
        if(Input.anyKey)
        {
            if (isAttacking == true)
            {
                if (gameObject.GetComponent<MovePlayer>().facingRight == false)
                {
                    gameObject.GetComponent<MovePlayer>().FlipPlayer();
                    gameObject.GetComponent<MovePlayer>().enabled = false;
                    gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                    projectile1.SetBool("isIdle", false);
                    anim.SetBool("Attack", true);

                }
                else
                {
                    gameObject.GetComponent<MovePlayer>().enabled = false;
                    gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                    projectile1.SetBool("isIdle", false);
                    anim.SetBool("Attack", true);
                }

            }
            else
            {
                projectile1.SetBool("isIdle", true);
                anim.SetBool("Attack", false);
                gameObject.GetComponent<MovePlayer>().enabled = true;

            }
        }

        if (Input.anyKey != true)
        {
            anim.SetBool("Attack", false);
            
        }

        // projectile1.GetFloat("WeakAtk");
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            isAttacking = true;
            projectile1.enabled = true;
            projectile1.Play("WeakAtk");
            projectile1.transform.position = anim.transform.position + new Vector3(0.9f, 0.1f, 0.0f);
        }
        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            projectile1.transform.position = new Vector3(-400.0f, 0.0f, 0);
            GameObject Charged = FireBullets(Charged1);
            Charged.transform.position = Launcher.transform.position;
            Charged.GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);
            isAttacking = false;
        }

        //if (Input.GetKeyDown(KeyCode.Keypad2))
        //{

        //    projectile2.SetBool("isIdle", false);
        //    anim.SetBool("Attack", true);
        //    projectile2.enabled = true;
        //    projectile2.Play("MediumAtk");
        //    Charged2.enabled = false;

        //    projectile2.transform.position = anim.transform.position + new Vector3(0.9f, 0.1f, 0.0f);
        //    if (projectile2.GetFloat("FixedTime") > 1)
        //    {
        //        projectile2.enabled = false;

        //    }

        //}
        //if (Input.GetKeyUp(KeyCode.Keypad2))
        //{
        //    Charged2.enabled = true;

        //    anim.SetBool("Attack", false);
        //    projectile2.speed.Equals(0.0f);
        //    projectile2.transform.position = new Vector3(-400.0f, 0.0f, 0);
        //    projectileSpeed = 0.1f;
        //    gameObject.GetComponent<MovePlayer>().enabled = true;
        //    Charged2.transform.position = anim.transform.position + new Vector3(0.9f, 0.1f, 0);
        //    projectile2.SetBool("isIdle", true);
        //}



        //if (Input.GetKeyDown(KeyCode.Keypad3))
        //{

        //    projectile3.SetBool("isIdle", false);
        //    anim.SetBool("Attack", true);
        //    projectile3.enabled = true;
        //    projectile3.Play("StrongAtk");
        //    Charged3.enabled = false;
        //    gameObject.GetComponent<MovePlayer>().facingRight = true;
        //    gameObject.GetComponent<MovePlayer>().enabled = false;
        //    gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        //    projectile3.transform.position = anim.transform.position + new Vector3(0.9f, 0.1f, 0.0f);

        //}
        //if (Input.GetKeyUp(KeyCode.Keypad3))
        //{

        //}




        //Charged3.transform.position += new Vector3(projectileSpeed, 0, 0);

        //Charged2.transform.position += new Vector3(projectileSpeed, 0, 0);

    }


}
