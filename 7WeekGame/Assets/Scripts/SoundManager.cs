using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance = null;
    //  Use this for initialization
    public AudioSource EffectsSource;
    public AudioSource MusicSource;
    public AudioClip Death;
    public AudioClip GlassCollision;
    public AudioClip Attack1;
    public AudioClip Attack2;
    public AudioClip Attack3;
    public AudioClip WallCollision;
    public AudioClip Explosion;
   

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













