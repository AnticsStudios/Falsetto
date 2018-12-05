using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour
{

    Animator anim;
    public Animator RealBigGlass;
    public Collider2D collider;


    public void Shatter()
    {
       
        Destroy(gameObject);
    }
      
   

    //Called upon when an object enters the trigger
    private void OnTriggerEnter(Collider2D collider)
    {
        //Checks for the player tag
        if (collider.gameObject.GetComponent<Player>() != null && collider.gameObject.tag == "Player")
        {
            //calls the function to kill the player
            anim.GetComponent<Player>().Dead();
        }
    }
}
