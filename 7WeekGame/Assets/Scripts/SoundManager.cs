﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource efxSource;                   
    public AudioSource musicSource;                 
    public void PlaySingle(AudioClip clip)
    {
        //Set the clip of our efxSource audio source to the clip passed in as a parameter.
       
        efxSource.clip = clip;

        //Play the clip.
        efxSource.Play();
    }

}
