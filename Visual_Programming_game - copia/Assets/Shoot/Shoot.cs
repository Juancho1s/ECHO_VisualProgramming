using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform cannon;

    public float bulletForce = 1500f;
    public float shootRate = 0.5f;
    public float shootRateTime = 0;
    public Animation pythonAnimation;
    public ReloadPython pythonReloadScript;
    IEnumerator wait (GameObject bulletNew)
    {
        yield return new WaitForSeconds(2f);
        DestroyImmediate(bulletNew, true);
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(Time.time>shootRateTime)
            {

                GameObject newBullet;
                newBullet = Instantiate(bullet,cannon.position,cannon.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(cannon.forward * bulletForce);

                shootRateTime = Time.time + shootRate;
                wait(newBullet);
                
            }
        }
        if(Input.GetKey(KeyCode.R))
        {
            pythonAnimation.Play();
            pythonReloadScript.enabled = true;
        }
    }
}
