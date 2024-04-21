using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudio : MonoBehaviour
{
    public AudioClip backgroundMusic;

    void Start() // 12
    {
        var audio = gameObject.AddComponent<AudioSource>();
        audio.volume = 0.5f;
        audio.clip = backgroundMusic;
        audio.Play();
    }
} //13 added a camera and adjusted it's position