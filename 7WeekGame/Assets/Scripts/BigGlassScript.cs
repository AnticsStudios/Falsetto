using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigGlassScript : MonoBehaviour
{

    Animator anim;
    public Animator projectile3;
    public Transform ActualPlayer;
 

    public SpriteRenderer Charged3;

    public MeshCollider chargedattack3;
    public BoxCollider2D GlassBHitbox;          //HitBoxes
    public CircleCollider2D Player;
    
    public Animator bigglass;

    public GameObject GlassB;
  
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

      


       
       

        projectile3.enabled = false;
        Charged3.enabled = false;

       
        projectile3.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    // Update is called once per frame

  

    void OnCollisionEnter2D(Collision2D GlassB)   // If player hits Heavy glass they Die
    {
        if  (Player)
        {
            anim.SetBool("Death", true);

        }
    }


    void OnCollisionEnter2D(Collider2D GlassBHitbox) // If if Charge attack hits Heavy glass breaks
    {
        
        if (Charged3)
        {
            bigglass.SetBool("BigGlass", true);


            Destroy(GlassB);

        }
    }

   
     
}