using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DoubleDoorOpen : MonoBehaviour
{
    public Animation leftDoor;
    public Animation rightDoor;
    public Component trigger;
    public new AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if(Input.GetKey(KeyCode.E))
        {
            audio.Play();
            leftDoor.Play();
            rightDoor.Play();
            trigger.GetComponent<BoxCollider>().enabled = false;

        }
        

    }
}
