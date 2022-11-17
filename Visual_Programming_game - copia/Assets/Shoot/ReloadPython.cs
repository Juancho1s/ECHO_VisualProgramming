using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadPython : MonoBehaviour
{
    public Shoot shoot;
    public ReloadPython reloadPython;
    // Start is called before the first frame update
    void OnEnable()
    {
        shoot.enabled = false;
        StartCoroutine(pythonReload());
    
    }
    IEnumerator pythonReload ()
    {
        yield return new WaitForSeconds(8f);
        shoot.enabled = true;
        Debug.Log("xd");
        reloadPython.enabled = false;
        
    }
}
