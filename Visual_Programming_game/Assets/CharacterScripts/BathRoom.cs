using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BathRoom : MonoBehaviour
{
   public Animation anim;
   public AudioSource audioDoor;
   public Component comp;
   public bool xd = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if(xd == true){
            if(Input.GetKey(KeyCode.E))
            {
                audioDoor.Play();
                anim.Play();
                comp.GetComponent<BoxCollider>().enabled = false;
                xd = false;
            }
        }
    }
}
