using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    private Animator animator;
    private bool TopBlink = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && !TopBlink)  //KeyCodeList (https://docs.unity3d.com/ScriptReference/KeyCode.html)
        {
            animator.SetBool("TopBlink", true);
            TopBlink = true;
        }
        else if (Input.GetKeyDown(KeyCode.T) && TopBlink)
        {
            animator.SetBool("TopBlink", false);
            TopBlink = false;
        }
    }
}
