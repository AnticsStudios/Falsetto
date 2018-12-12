using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyGame : MonoBehaviour {

    public GameObject LevelSpawn, ReadyButton;
    public bool started = false;
    public int timefloat = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timefloat = (int)Time.time+1;

        if ((timefloat % 14) == 0 && started) 
        {
            LevelSpawn.SetActive(true);
            started = false;
        }
    }

    public void readygame()
    {
        started = true;
        ReadyButton.SetActive(false);
       
    }
}
