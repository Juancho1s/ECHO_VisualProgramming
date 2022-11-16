using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SongSampleScene : MonoBehaviour
{
    // Start is called before the first frame update
    public new AudioSource audio;
    void Start()
    {
        StartCoroutine(wait());
    }

    // Update is called once per frame
    IEnumerator wait()
    {
        yield return new WaitForSeconds(130f);
        audio.Play();
    }
}
