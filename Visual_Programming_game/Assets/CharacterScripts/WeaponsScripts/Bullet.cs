using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 20f;
    void Start()
    {
        Destroy(gameObject, 3);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(transform.GetComponent<Rigidbody>());
        if (other.tag == "SimpleZombie")
        {
            transform.parent = other.transform;
            other.GetComponent<Attributes>().takeDamage(damage);
        }
    }
}
