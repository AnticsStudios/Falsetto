using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timebugfix : MonoBehaviour {
    public float unusableMenuTime;
    public GameObject loaderObject;
    // Use this for initialization
    void Start () {

    }
	
    void fixTime()
    {
       
    }
	// Update is called once per frame
	void Update () {
        if (loaderObject.GetComponent<LoadSceneScript>().isStarted != true)
        {
            unusableMenuTime = Time.time;

        }


    }
}
