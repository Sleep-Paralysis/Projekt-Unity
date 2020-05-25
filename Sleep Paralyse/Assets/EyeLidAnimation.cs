using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeLidAnimation : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    [SerializeField] private Animator myAnimationController2;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            myAnimationController.SetBool("PlaySpin2", true);
        }

        if (other.CompareTag("Player"))
        {
            myAnimationController2.SetBool("PlaySpin2", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("PlaySpin2", false);
        }

        if (other.CompareTag("Player"))
        {
            myAnimationController2.SetBool("PlaySpin2", false);
        }
    }
}

