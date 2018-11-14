using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public bool isdDead;
    public int[] soundPitch;

    //Transform checks for walls
    private Transform Glass1;
    private Transform Glass2;
    private Transform Glass3;

    // Use this for initialization
    void Start()
    {
        //Tag checks to compare the pitch with
        Glass1 = GameObject.FindGameObjectWithTag("Glass1").transform;
        Glass2 = GameObject.FindGameObjectWithTag("Glass2").transform;
        Glass3 = GameObject.FindGameObjectWithTag("Glass3").transform;

        //Array to contain each value of the sound pitch to break different thicknesses of glass
        soundPitch = new int[3];

        soundPitch[0] = 1;
        soundPitch[1] = 2;
        soundPitch[2] = 3;

    }

    // Update is called once per frame
    void Update()
    {   
        //Casts a ray
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);

        //If the ray hits something
        if (hit.collider != null)
        {
            float distance = Mathf.Abs(hit.point.x - transform.position.x);
            
            //If the distance is lower than 10 then it checks the tag and compare it with the soundPitch
            //If it matches, then it calls the function to break the glass wall
            if(distance < 10)
            {
                //if (Ray2D.gameObject.GetComponent<Player>() != null && RaycastHit2D.gameObject.tag == "Player")
            }

        }
    }

    //called when the player dies
    public void Deaderino()
    {

    }
}
