﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{

    public static SoundManager instance;

    AudioSource audioSource;

    public AudioClip soundDrawerOpen;
    public AudioClip soundDrawerClose;
    public AudioClip soundPhoneOn;
    public AudioClip soundClick;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayDrawerOpenSound()
    {
        audioSource.PlayOneShot(soundDrawerOpen);
    }

    public void PlayDrawerCloseSound()
    {
        audioSource.PlayOneShot(soundDrawerClose);
    }

    public void PlayClickSound()
    {
        audioSource.PlayOneShot(soundClick);
    }

    public void PlayPhoneOnSound()
    {
        audioSource.PlayOneShot(soundPhoneOn);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
