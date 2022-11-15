using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicStartBunker : MonoBehaviour
{
    public new AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        PlayAudio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PlayAudio()
    {
        audio.Play();
    }
}
