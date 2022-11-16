using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class KeyPicker : MonoBehaviour
{
    public new AudioSource audio;
    public Component com;
    public Component com2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Key")
        {
            audio.Play();
            com.GetComponent<BoxCollider>().enabled = true;
            com2.GetComponent<BoxCollider>().enabled = false;
            Destroy(col.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
