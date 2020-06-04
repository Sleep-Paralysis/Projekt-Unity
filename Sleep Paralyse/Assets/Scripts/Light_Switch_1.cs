using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Switch_1 : MonoBehaviour
{
    public GameObject instructions;
    public GameObject light;
    private bool on = false;

    void OnTriggerStay(Collider plyr) {
        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !on)
        {
            instructions.SetActive(true);
            light.SetActive(true);
            on = true;
        }
        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && on)
        {
            light.SetActive(false);
            on = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Door")
        {
            instructions.SetActive(false);
        }
    }
}
