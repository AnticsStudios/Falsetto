using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDestroy : MonoBehaviour {
    public AudioSource EffectsSource;


	// Use this for initialization
	void Start () {
		
	}
	public void BombDestroyer()
    {
        Destroy(this.gameObject);
    }
    public void onPlayBombSound()
    {
        //EffectsSource.clip = Bomb;
        EffectsSource.Play();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
