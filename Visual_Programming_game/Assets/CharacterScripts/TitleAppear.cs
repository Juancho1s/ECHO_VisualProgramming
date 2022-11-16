using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleAppear : MonoBehaviour
{
    private CanvasGroup cs;
    [SerializeField] private CanvasGroup c;
    // Start is called before the first frame update
    void Start()
    {
        cs = GetComponent<CanvasGroup>();

        //sincronize title alpha with the animation to don't disappear when animation finish.
        Invoke("changeAlpha",12.5f);

    }

    // Update is called once per frame
    void changeAlpha(){
        //Make appear title.
        cs.alpha=1f;
    }
}
