using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript2 : MonoBehaviour
{
    private Animator animator;
    private bool BottomBlink = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && !BottomBlink)  //KeyCodeList (https://docs.unity3d.com/ScriptReference/KeyCode.html)
        {
            animator.SetBool("BottomBlink", true);
            BottomBlink = true;

        }
        else if (Input.GetKeyDown(KeyCode.T) && BottomBlink)
        {
            animator.SetBool("BottomBlink", false);
            BottomBlink = false;
        }
    }
}
