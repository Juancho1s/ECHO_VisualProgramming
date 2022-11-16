using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class InitGame : MonoBehaviour
{
    // Start is called before the first frame update
    public new AudioSource audio;
    int a = 0;
    void Start()
    {
        //Wait 1.5 second to start playing the song
        PlayAudio();
    }
    void Update(){

        if (Input.GetKey(KeyCode.Return)){
            a = 1;
        }
        if (a==1){
            audio.volume = audio.volume - 0.0008f;
        }
    }

    void PlayAudio()
    {
        audio.Play();
    }
}
