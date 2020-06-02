using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUIButton : MonoBehaviour
{

    public GameObject uiObject;

    void Start()
    {
        uiObject.SetActive(false);
    }


    void OnTriggerStay(Collider plyr)
    {
        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
        IEnumerator WaitForSec()
        {
            yield return new WaitForSeconds(5);
            Destroy(uiObject);
            Destroy(gameObject);
        }


}
