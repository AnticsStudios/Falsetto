using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    Player player;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void BlowUp()
    {
        player.GetComponent<Player>().Deaderino();
    }

    //Called when an object enters the trigger
    private void OnTriggerEnter (Collider collider)
    {
        //Checks for the player tag
        if (player.gameObject.tag == "Player")
        {
            BlowUp();
        }
    }
}
