using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeX = 20.35f;
    public GameObject letsFixTimeBug;
    public float unusabletime;

    private Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position;
        letsFixTimeBug = GameObject.FindGameObjectWithTag("TimeBugFixer");
        unusabletime = -letsFixTimeBug.GetComponent<timebugfix>().unusableMenuTime;
    }

    void FixedUpdate()
    {
        if (unusabletime < 0)
        {
            float newPosition = Mathf.Repeat((Time.time + unusabletime) * scrollSpeed, tileSizeX);
            transform.position = startPosition + Vector2.right * newPosition;
        }
    }

    
}

