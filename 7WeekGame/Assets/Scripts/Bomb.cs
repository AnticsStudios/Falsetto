using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    Player player;

    void BlowUp()
    {
        player.GetComponent<Player>().Dead();
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
