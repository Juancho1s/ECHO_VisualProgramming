using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AmmoPicker : MonoBehaviour
{
    // Start is called before the first frame update
    public Shoot shoot1;
    public AudioSource audio;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Ammo")
        {
            audio.Play();
            shoot1.ammo = shoot1.ammo + 4;
            col.enabled = false;

            Destroy(col.gameObject);
        }   
    }
}
