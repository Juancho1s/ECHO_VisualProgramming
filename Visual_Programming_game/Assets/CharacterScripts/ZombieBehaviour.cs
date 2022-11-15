using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBehaviour : MonoBehaviour
{
    public bool w = false,  a = false, s = false, d = false, sh = false; 
    public AudioClip steps;
    public float soundIntensity = 20f;
    public LayerMask zombieLayer;
    public float walkPerception = 1.5f;
    public float sprintPerception = 2f;

    private AudioSource audioSource;
    private movement TDP;
    private SphereCollider sphereCollider;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        sphereCollider = GetComponent<SphereCollider>();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fire();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            sh = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            sh = false;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            w = true;
            sphereCollider.radius = walkPerception;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            w = false;
            sphereCollider.radius = 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            a = true;
            sphereCollider.radius = walkPerception;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            a = false;
            sphereCollider.radius = 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            s = true;
            sphereCollider.radius = walkPerception;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            s = false;
            sphereCollider.radius = 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            d = true;
            sphereCollider.radius = walkPerception;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            d = false;
            sphereCollider.radius = 0.5f;
        }
        if (w == true & sh == true)
        {
            sphereCollider.radius = sprintPerception;
        }
    }

    public void fire()
    {
        
        //audioSource.PlayOneShot(steps);
        Collider[] zombies = Physics.OverlapSphere(transform.position, soundIntensity, zombieLayer);
        for (int i = 0; i < zombies.Length; i++)
        {
            zombies[i].GetComponent<SimpleZombie>().onAware();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SimpleZombie"))
        {
            other.GetComponent<SimpleZombie>().onAware();
        }
    }
}
