using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void BombDestroyer()
    {
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
