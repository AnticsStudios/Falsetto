using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance = null;
    //  Use this for initialization
    public AudioSource EffectsSource;
    public AudioSource MusicSource;
    public AudioClip PlayerAttack1;
    public AudioClip PlayerAttack2;
    public AudioClip PlayerAttack3;
    public AudioClip Death;
    public AudioClip Glass1;
    public AudioClip Glass2;
    public AudioClip Glass3;
    public AudioClip Explosion;
    public AudioClip Wall;


    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != null)
        {
            Destroy(gameObject);
        }
    }
        public void PlaySingle(AudioClip clip)
        {
        EffectsSource.clip = clip;
        EffectsSource.Play();
        }
        public void MusicBackground(AudioSource Background)
        {
        MusicSource.Play();
        }

}













