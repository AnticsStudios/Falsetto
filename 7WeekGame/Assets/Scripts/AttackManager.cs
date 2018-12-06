using System.Collections;
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
    private int i = 0;
  
    void Start ()
    {
        anim = GetComponent<Animator>();
    }


    GameObject FireBullets(GameObject name)
    {

        GameObject ChargedUpShot = Instantiate(name) as GameObject;
        return ChargedUpShot;

    }

    void cleanClones(string cloneName)
    {
        var clones = GameObject.FindGameObjectsWithTag("" + cloneName + "");
            foreach (var clone in clones)
            {
                Destroy(clone);
            }

    }

    void Update ()
    {

        if (Input.anyKey)
        {
            if (isAttacking == true)
            {
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
            
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            isAttacking = true;

            projectile1.SetBool("isIdle", false);
            projectile1.transform.position = Launcher.transform.position;
        }

        if (Input.GetKeyUp(KeyCode.Keypad1))
        {

            projectile1.SetBool("isIdle", true);
            projectile1.transform.position = new Vector3(-400.0f, 0.0f, 0);

            GameObject Charged = FireBullets(Charged1);
            Charged.gameObject.tag = "WeakAtk";

            Charged.transform.position = Launcher.transform.position;
            Charged.GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);

            isAttacking = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            isAttacking = true;

            projectile2.SetBool("isIdle", false);
            projectile2.transform.position = Launcher.transform.position;
        }

        if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            projectile2.SetBool("isIdle", true);
            projectile2.transform.position = new Vector3(-400.0f, 0.0f, 0);

            GameObject ChargedTwo = FireBullets(Charged2);
            ChargedTwo.gameObject.tag = "MediumAtk";

            ChargedTwo.transform.position = Launcher.transform.position;
            ChargedTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);

            isAttacking = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            isAttacking = true;

            projectile3.SetBool("isIdle", false);
            projectile3.transform.position = Launcher.transform.position;
        }
        if (Input.GetKeyUp(KeyCode.Keypad3))
        {
            projectile3.SetBool("isIdle", true);
            projectile3.transform.position = new Vector3(-400.0f, 0.0f, 0);

            GameObject ChargedThree = FireBullets(Charged3);
            ChargedThree.gameObject.tag = "StrongAtk";

            ChargedThree.transform.position = Launcher.transform.position;
            ChargedThree.GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);

            isAttacking = false;
        }
    }


}
