using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    public float damage = 40f;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SimpleZombie")
        {
            transform.parent = other.transform;
            other.GetComponent<Attributes>().takeDamage(damage);
        }
    }
}
