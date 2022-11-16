using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    private Animator animator;
    [SerializeField] private AnimationClip finalAnimation;
    // Start is called before the first frame update
    void Start()
    {
        //Start the final animation
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //If you press Enter in your keyboard, th scene will change
        if (Input.GetKey(KeyCode.Return))
        {
            StartCoroutine(ChangeScene());
        }
    }
    IEnumerator ChangeScene(){
        animator.SetTrigger("start");
        yield return new WaitForSeconds(finalAnimation.length);
        SceneManager.LoadScene("StartBunker");
    }
}

