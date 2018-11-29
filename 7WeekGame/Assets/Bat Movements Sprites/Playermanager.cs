using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermanager : MonoBehaviour {
    Animator anim;
    public Animator projectile1;
    public Animator projectile2;
    public Animator projectile3;

    public SpriteRenderer Charged;
    public SpriteRenderer Charged2;
    public SpriteRenderer Charged3;

    public float projectileSpeed = 0f;
    int pos = 0;
    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();

        projectile1.enabled = false;
        Charged.enabled = false;


        projectile2.enabled = false;
        Charged2.enabled = false;

        projectile3.enabled = false;
        Charged3.enabled = false;

        projectile1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        projectile2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        projectile3.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
	
	// Update is called once per frame
	void Update ()
    {
        // projectile1.GetFloat("WeakAtk");

        if (Input.GetKeyDown(KeyCode.W) && pos < 1)
        {
            Debug.Log(pos);
            pos += 1;
            anim.SetFloat("VertMovement", pos);
            Debug.Log("w pressed");
            Debug.Log(pos);
        }


        if (Input.GetKeyDown(KeyCode.S) && pos > -1)
        {
            Debug.Log(pos);
            pos -= 1;
            anim.SetFloat("VertMovement", pos);
            Debug.Log("s pressed");
            Debug.Log(pos);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            projectile1.SetBool("isIdle", false);
            anim.SetBool("Attack", true);
            projectile1.enabled = true;
            projectile1.Play("WeakAtk");
            Charged.enabled = false;
            projectile1.transform.position = anim.transform.position + new Vector3(0.9f, 0.1f, 0.0f);
            if(projectile1.GetFloat("WeakAtk") > 3)
            {
                projectile1.enabled = false;

            }
        }
        else if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Charged.enabled = true;

            anim.SetBool("Attack", false);
            projectile1.speed.Equals(0.0f);
            projectile1.transform.position = new Vector3(-400.0f, 0.0f, 0);
            projectileSpeed = 0.1f;

            Charged.transform.position = anim.transform.position + new Vector3(0.9f, 0.1f, 0);
            projectile1.SetFloat("WeakAtk", 0);
            projectile1.SetBool("isIdle", true);

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            projectile2.enabled = true;
            Charged2.enabled = false;
            anim.SetBool("Attack", true);
            projectile2.Play("MediumAtk");
            projectile2.transform.position = anim.transform.position + new Vector3(0.9f, 0.1f, 0.0f);

        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            Charged2.enabled = true;
            projectile2.enabled = false;

            anim.SetBool("Attack", false);
            projectile2.speed.Equals(0.0f);
            projectile2.transform.position = new Vector3(-400.0f, 0.0f, 0);
            projectileSpeed = 0.1f;

            Charged2.transform.position = anim.transform.position + new Vector3(0.9f, 0.1f, 0);
        }



        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            projectile3.enabled = true;
            Charged3.enabled = false;
            anim.SetBool("Attack", true);
            projectile3.Play("StrongAtk");
            projectile3.transform.position = anim.transform.position + new Vector3(0.9f, 0.1f, 0.0f);

        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            Charged3.enabled = true;
            projectile3.enabled = false;

            anim.SetBool("Attack", false);
            projectile3.speed.Equals(0.0f);
            projectile3.transform.position = new Vector3(-400.0f, 0.0f, 0);
            projectileSpeed = 0.1f;

            Charged3.transform.position = anim.transform.position + new Vector3(0.9f, 0.1f, 0);
        }




        Charged3.transform.position += new Vector3(projectileSpeed, 0, 0);

        Charged2.transform.position += new Vector3(projectileSpeed, 0, 0);

        Charged.transform.position += new Vector3(projectileSpeed, 0, 0);
    }


}
