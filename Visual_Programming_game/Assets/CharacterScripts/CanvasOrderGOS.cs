using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasOrderGOS : MonoBehaviour
{
    Canvas bien;
    [SerializeField] private Canvas canvasBien;
    // Start is called before the first frame update
    void Start()
    {
        bien = GetComponent<Canvas>();

        StartCoroutine(waits());
    }

    IEnumerator waits(){
        yield return new WaitForSeconds(12f);
        bien.sortingOrder = -1;
    }
}
