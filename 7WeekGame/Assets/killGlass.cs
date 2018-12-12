using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killGlass : MonoBehaviour {
    public AudioClip Glass1;
    public AudioSource EffectsSource;

    // Use this for initialization
    void Start () {
		
	}
    public void destroyGlass()
    {
        Destroy(this.gameObject);
    }
    public void soundGlass()
    {
        EffectsSource.clip = Glass1;
        EffectsSource.Play();
    }
        // Update is called once per frame
        void Update () {
		
	}
}
