using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenKeyDoor : MonoBehaviour
{
    public Animation animation;
    public Component comp;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if(Input.GetKey(KeyCode.E))
        {
            animation.Play();
            audio.Play();
            comp.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
