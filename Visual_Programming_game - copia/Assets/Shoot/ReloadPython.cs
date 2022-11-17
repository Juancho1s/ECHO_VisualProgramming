using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadPython : MonoBehaviour
{
    public Shoot shoot;
    public ReloadPython reloadPython;
    private int tester = 0;
    // Start is called before the first frame update
    void OnEnable()
    {
        shoot.enabled = false;
        StartCoroutine(pythonReload());
    
    }
    IEnumerator pythonReload ()
    {
        yield return new WaitForSeconds(7.5f);
        shoot.enabled = true;

        //Have ammo
        if(shoot.ammo > 0)
        {
            //Have less than 6 bullets
            if(shoot.ammo < 6)
            {
                if(shoot.charger > 0)
                {
                    tester = 6 - shoot.charger;
                    shoot.charger = shoot.charger + tester;
                    shoot.ammo = shoot.ammo - tester;
                }
                else
                {
                    shoot.charger = shoot.ammo;
                    shoot.ammo -= shoot.ammo;
                }
            }
            else
            {
                if(shoot.charger > 0)
                {
                    tester = 6 - shoot.charger;
                    shoot.charger = shoot.charger + tester;
                    shoot.ammo = shoot.ammo - tester;
                }
                else
                {
                    shoot.charger = 6;
                    shoot.ammo -= 6;
                }
                
            }
        }
        reloadPython.enabled = false;
        
    }
}
