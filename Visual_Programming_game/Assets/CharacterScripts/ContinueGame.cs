using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinueGame : MonoBehaviour
{
    private Animator animations;
    [SerializeField] private AnimationClip animationSelect;
    // Start is called before the first frame update
    void Start()
    {
        //Start the final animation
        animations = GetComponent<Animator>();
    }
    public void Run()
    {
        Debug.Log("xd");
        StartCoroutine(Restart());
    }

    // Update is called once per frame
    public IEnumerator Restart()
    {
        animations.SetTrigger("Restart");
        yield return new WaitForSeconds(animationSelect.length);
        SceneManager.LoadScene("MainMenu");
    }
}
