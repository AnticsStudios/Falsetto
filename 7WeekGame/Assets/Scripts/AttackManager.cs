using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Attack Manager Script
 * Sorry for my lack of previous comments guys - Chris
 * This script generates a prefab for the players projectiles
 * Reads the inputs and based upon the players position will flip the player or shoot
 * Enables the attack animation based upon different attacks
 * Enables bat mouth to open
 * Based upon input 1,2,3 a different pitch will be projected
 * We consistently check to clean the clones of the projectile
 * thats it.
 */

public class AttackManager : MonoBehaviour
{
    Animator anim;
    public Animator projectile1;
    public Animator projectile2;
    public Animator projectile3;
    public GameObject Charged1;
    public GameObject Charged2;
    public GameObject Charged3;
    public GameObject[] cloneTracker;
    public Transform Launcher;
    public bool isAttacking = false;
    public float deathTime = 5.0f;
    public float timer;
    bool isHoldingKey;

    void Start()
    {
        anim = GetComponent<Animator>();

    }


    GameObject FireBullets(GameObject name)
    {

        GameObject ChargedUpShot = Instantiate(name) as GameObject;
        return ChargedUpShot;

    }



    public void cleanClones()
    {
        var clones = GameObject.FindGameObjectsWithTag("WeakAtk");

        foreach (var clone in clones)
        {
            Destroy(clone, deathTime);
        }

    }

    public void cleanClones2()
    {
        var clones = GameObject.FindGameObjectsWithTag("MediumAtk");

        foreach (var clone in clones)
        {
            Destroy(clone, deathTime);
        }

    }

    public void cleanClones3()
    {
        var clones = GameObject.FindGameObjectsWithTag("StrongAtk");

        foreach (var clone in clones)
        {
            Destroy(clone, deathTime);
        }

    }

    void Update()
    {

        if (Input.anyKey)
        {
            isHoldingKey = true;
            if (isAttacking == true)
            {
                timer += 1.0F * Time.deltaTime;
                //if the player is not facing right 
                if (gameObject.GetComponent<MovePlayer>().facingRight == false)
                {
                    gameObject.GetComponent<MovePlayer>().FlipPlayer();
                    gameObject.GetComponent<MovePlayer>().enabled = false;
                    gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                    anim.SetBool("Attack", true);

                }
                //if the player is facing right
                else
                {
                    gameObject.GetComponent<MovePlayer>().enabled = false;
                    gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                    anim.SetBool("Attack", true);
                }

            }
            else //If player isn't attacking
            {
                anim.SetBool("Attack", false);
                if (anim.GetBool("Death") == true)
                {
                    gameObject.GetComponent<MovePlayer>().enabled = false;
                }
                else
                {
                    gameObject.GetComponent<MovePlayer>().enabled = true;
                }
            }

        }



        if (Input.anyKey != true)
        {
            anim.SetBool("Attack", false);
            isHoldingKey = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {

            isAttacking = true;
            projectile1.SetBool("failedToCharge", false);
            projectile1.SetBool("isIdle", false);
            projectile1.transform.position = Launcher.transform.position;
            
        }

        if (Input.GetKeyUp(KeyCode.Keypad1))
        {

            if (timer >= 0.25f)
            {
                projectile1.SetBool("isIdle", true);
                projectile1.transform.position = new Vector3(-400.0f, 0.0f, 0);
                GameObject Charged = FireBullets(Charged1);
                Charged.gameObject.tag = "WeakAtk";

                Charged.transform.position = Launcher.transform.position;
                Charged.GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);

                isAttacking = false;
                Invoke("cleanClones", 10);
                timer = 0;
            }
            if ((timer < 0.32f) && (isHoldingKey == false))
            {
                isAttacking = false;
                projectile1.SetBool("failedToCharge", true);
                projectile1.SetBool("isIdle", true);
                timer = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            isAttacking = true;
            projectile2.SetBool("failedToCharge", false);
            projectile2.SetBool("isIdle", false);
            projectile2.transform.position = Launcher.transform.position;
        }

        if (Input.GetKeyUp(KeyCode.Keypad2))
        {


            if (timer >= 0.35f)
            {
                projectile2.transform.position = new Vector3(-400.0f, 0.0f, 0);
                projectile2.SetBool("isIdle", true);
                GameObject ChargedTwo = FireBullets(Charged2);
                ChargedTwo.gameObject.tag = "MediumAtk";

                ChargedTwo.transform.position = Launcher.transform.position;
                ChargedTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);

                isAttacking = false;
                Invoke("cleanClones2", 10);
                timer = 0;
            }
            else if((timer < 0.35f) && (isHoldingKey == false))
            {
                isAttacking = false;
                projectile2.SetBool("failedToCharge", true);
                projectile2.SetBool("isIdle", true);
                timer = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            isAttacking = true;
            projectile3.SetBool("failedToCharge", false);
            projectile3.SetBool("isIdle", false);
            projectile3.transform.position = Launcher.transform.position;
        }
        if (Input.GetKeyUp(KeyCode.Keypad3))
        {
            if (timer >= .45f)
            {
                projectile3.transform.position = new Vector3(-400.0f, 0.0f, 0);
                projectile3.SetBool("isIdle", true);
                GameObject ChargedThree = FireBullets(Charged3);
                ChargedThree.gameObject.tag = "StrongAtk";

                ChargedThree.transform.position = Launcher.transform.position;
                ChargedThree.GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);

                isAttacking = false;
                Invoke("cleanClones3", 10);
                timer = 0;
            }
            else if(timer < .45f && (isHoldingKey == false))
            {
                isAttacking = false;
                projectile3.SetBool("failedToCharge", true);
                projectile3.SetBool("isIdle", true);
                timer = 0;
            }
        }

    }


}
