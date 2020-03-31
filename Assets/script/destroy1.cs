using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy1 : MonoBehaviour
{

    public AudioClip deathsound;
    private AudioSource playerdeath1;

    void Start()
    {
        playerdeath1 = GetComponent<AudioSource>();
    }
    

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
           Destroy(gameObject);
            playerdeath1.PlayOneShot(deathsound, 1.0f);
        }
        
    }
}
