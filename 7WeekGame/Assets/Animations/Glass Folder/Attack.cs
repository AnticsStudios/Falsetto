using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            anim.SetBool("Attack", true);
            anim.Play("attack small 800 x 200_0");

            Debug.Log("Alpha1");

        }
        else
        {
            anim.SetBool("Attack", false);
        }
    }
}