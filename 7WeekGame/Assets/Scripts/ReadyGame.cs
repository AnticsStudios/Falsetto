using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyGame : MonoBehaviour {

    public GameObject LevelSpawn, ReadyButton;
    public bool started = false;
    public bool started2 = false;
    public int timefloat = 0;
    public float timefloat2;
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

        switch (started2)
        {
           case true:
                
        break;
        case false:
                timefloat2 = (int)Time.time;
                break;

        }

    }
    

    public void readygame()
    {

        started = true;
        started2 = true;
        ReadyButton.SetActive(false);
    }
}
