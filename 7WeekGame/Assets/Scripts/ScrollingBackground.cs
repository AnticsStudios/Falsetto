using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeX = 20.35f;
    public GameObject letsFixTimeBug;
    public float unusabletime;
    private float newTime;
    private Vector2 startPosition;


    void Start()
    {
        unusabletime = -Time.time;

        startPosition = transform.position;
        // letsFixTimeBug = GameObject.FindGameObjectWithTag("TimeBugFixer");
        //unusabletime = -letsFixTimeBug.GetComponent<timebugfix>().unusableMenuTime;
    }

    void FixedUpdate()
    {
        newTime += Time.deltaTime;
            float newPosition = Mathf.Repeat((newTime - unusabletime) * scrollSpeed, tileSizeX);
            transform.position = startPosition + Vector2.right * newPosition;

    }

    
}

