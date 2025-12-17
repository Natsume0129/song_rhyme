using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaChange : MonoBehaviour
{
    // Start is called before the first frame update
    private CanvasGroup canvasgroups;
    void Start()
    {
        canvasgroups=GetComponent<CanvasGroup>();
        canvasgroups.alpha=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(canvasgroups.alpha<1)
        {
            canvasgroups.alpha+=0.001f;
        }
    }
}
