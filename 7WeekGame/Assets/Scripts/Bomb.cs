using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    Player ActualPlayer;

    void BlowUp()
    {
        ActualPlayer.GetComponent<Player>().Dead();
    }

    //Called when an object enters the trigger
    private void OnTriggerEnter (Collider collider)
    {
        //Checks for the player tag
        if (ActualPlayer.gameObject.tag == "Player")
        {
            BlowUp();
        }
    }
}
