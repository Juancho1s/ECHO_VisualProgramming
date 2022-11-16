using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class LockedDoorSound : MonoBehaviour
{
    public new AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay()
    {
        if(Input.GetKey(KeyCode.E))
        {
            audio.Play();
        }
    }
}
