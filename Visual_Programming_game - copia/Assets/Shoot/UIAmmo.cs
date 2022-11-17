using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAmmo : MonoBehaviour
{
    public Shoot shoot;
    public Text ammoUI;
    public Text chargeUI;
    // Update is called once per frame
    void Update()
    {
        ammoUI.text = shoot.ammo.ToString();
        chargeUI.text = shoot.charger.ToString();
    }
}
