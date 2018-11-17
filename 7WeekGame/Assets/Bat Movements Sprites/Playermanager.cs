using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermanager : MonoBehaviour {
    Animator anim;
    int pos = 0;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();

        
	}
	
	// Update is called once per frame
	void Update ()
    {


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

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Attack", true);
            Debug.Log("space pressed");

        }
        else
        {
            anim.SetBool("Attack", false);
        }
    }
}
