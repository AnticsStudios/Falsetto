using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isdDead;
    public int[] pitchArray;

    public float accel = 6f;
    public float speed = 6f;

    private bool isGoingUp;
    private bool isGoingDown;
    private float YeetSpeedUp = 2f;
    private float YeetSpeedDown = -2f;

    private Vector2 input;

    //Glass checks for walls
    Glass Glass1;
    Glass Glass2;
    Glass Glass3;

    private Animator animator;
    private Rigidbody2D rigidbody;

    //called when the player dies
    public void Dead()
    {
        isdDead = true;
    }

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
        
 