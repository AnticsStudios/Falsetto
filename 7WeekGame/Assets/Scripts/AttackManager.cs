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
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            isAttacking = true;
            projectile1.enabled = true;
            projectile1.Play("WeakAtk");
            projectile1.transform.position = anim.transform.position + new Vector3(0.9f, 0.1f, 0.0f);
        }
        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            GameObject Charged = FireBullets(Charged1);
            projectile1.transform.position = new Vector3(-400.0f, 0.0f, 0);
            Charged.gameObject.tag = "Clone";


            var clones = GameObject.FindGameObjectsWithTag("Clone");
            i++;
            if (i > 10)
            {
                foreach (var clone in clones)
                {
                    Destroy(clone);
                }
                i = 0;
            }

            Charged.transform.position = Launcher.transform.position;
            Charged.GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);
            isAttacking = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            isAttacking = true;
            projectile2.enabled = true;
            projectile2.Play("MediumAtk");
            projectile2.transform.position = anim.transform.position + new Vector3(0.9f, 0.1f, 0.0f);
        }
        if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            GameObject ChargedTwo = FireBullets(Charged2);
            ChargedTwo.transform.position = Launcher.transform.position;
            projectile2.transform.position = new Vector3(-400.0f, 0.0f, 0);
            ChargedTwo.gameObject.tag = "Clone";

            ChargedTwo.GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);
            var clones = GameObject.FindGameObjectsWithTag("Clone");
            i++;
            if (i > 10)
            {
                foreach (var clone in clones)
                {
                    Destroy(clone);
                }
                i = 0;
            }
            isAttacking = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            isAttacking = true;
            projectile3.enabled = true;
            projectile3.Play("StrongGlass");
            projectile3.transform.position = anim.transform.position + new Vector3(0.9f, 0.1f, 0.0f);

        }
        if (Input.GetKeyUp(KeyCode.Keypad3))
        {
            GameObject ChargedThree = FireBullets(Charged3);
            projectile3.transform.position = new Vector3(-400.0f, 0.0f, 0);
            ChargedThree.gameObject.tag = "Clone";

            var clones = GameObject.FindGameObjectsWithTag("Clone");
            i++;
            if (i > 10)
            {
                foreach (var clone in clones)
                {
                    Destroy(clone);
                }
                i = 0;
            }
            ChargedThree.transform.position = Launcher.transform.position;
            ChargedThree.GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);
            isAttacking = false;
        }
    }


}
