using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform cannon;

    public float bulletForce = 1500f;
    public float shootRate = 1.2f;
    public int ammo = 2;
    public int charger = 6;
    private float shootRateTime = 0;
    public new AudioSource revolverShootSound;
    public new AudioSource noAmmo;
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
                if(charger > 0)
                {
                    revolverShootSound.Play();
                    GameObject newBullet;
                    newBullet = Instantiate(bullet,cannon.position,cannon.rotation);
                    newBullet.GetComponent<Rigidbody>().AddForce(cannon.forward * bulletForce);

                    shootRateTime = Time.time + shootRate;

                    charger -= 1;

                    StartCoroutine(wait(newBullet));
                }
                else
                {
                    if(ammo > 0)
                    {
                        pythonAnimation.Play();
                        pythonReloadScript.enabled = true;
                    }
                    else
                    {
                        noAmmo.Play();
                    }
                    
                }
                
            }
        }
        else if(Input.GetKey(KeyCode.R))
        {
            if(ammo > 0)
            {
                if(charger < 6)
                {
                    pythonAnimation.Play();
                    pythonReloadScript.enabled = true;
                }
                
            }
        }
    }
}
