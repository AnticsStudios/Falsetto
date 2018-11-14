using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public bool isdDead;
    public int[] soundPitch;

    //Glass checks for walls
    private Glass Glass1;
    private Glass Glass2;
    private Glass Glass3;

    // Use this for initialization
    void Start()
    {
       
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
        RaycastHit2D hit = Physics2D.Raycast(Glass.position, Vector2.right);

        //If the ray hits something
        if (hit.collider != null)
        {
            float distance = Mathf.Abs(hit.point.x - Glass.position.x);
            
            //If the distance is lower than 10 then it checks the tag and compare it with the soundPitch
            //If it matches, then it calls the function to break the glass wall
            if(distance < 10)
            {
                if (hit.collider.gameObject.tag == "Glass1")
                {
                        if (pitchArray[0] == 1)
                        {
                            Glass1.GetComponent<Glass>().Shatter();                      
                        }
                }
                else if (hit.collider.gameObject.tag == "Glass2")
                {
                    if (pitchArray[1] == 2)
                    {
                        Glass1.GetComponent<Glass>().Shatter();
                    }
                }
                if (hit.collider.gameObject.tag == "Glass3")
                {
                    if (pitchArray[2] == 3)
                    {
                        Glass1.GetComponent<Glass>().Shatter();
                    }
                }
            }

        }
    }

    //called when the player dies
    public void Deaderino()
    {

    }
}
