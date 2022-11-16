using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComponentsMainMenu : MonoBehaviour
{
    private Animator titleAnimation;
    private Animator enterAnimation;
    [SerializeField] private AnimationClip initialAnimation;
    [SerializeField] private AnimationClip titleAnimationLenght;
    // Start is called before the first frame update
    void Start()
    {
        titleAnimation = GetComponent<Animator>();
        enterAnimation = GetComponent<Animator>();

        StartCoroutine(startWait());
        StartCoroutine(titleWait());

    }
    IEnumerator startWait()
    {
        yield return new WaitForSeconds(6f);
        titleAnimation.SetTrigger("Start1");
        
    }
    IEnumerator titleWait(){
        yield return new WaitForSeconds(12f);
        enterAnimation.SetTrigger("Start2");

        
    }
}
