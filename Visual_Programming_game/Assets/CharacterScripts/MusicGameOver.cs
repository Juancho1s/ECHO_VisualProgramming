using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicGameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public new AudioSource music;
    void Start()
    {
        music.Play();
    }

}
