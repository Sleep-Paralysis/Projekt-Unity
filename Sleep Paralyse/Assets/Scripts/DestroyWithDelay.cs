using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithDelay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          Destroy(gameObject, 7f); // Destroy Gameobject, after 2 Seconds.
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //  if (collision.gameObject.tag == "Ground")
    //{
    //  Destroy(gameObject); // Just destroy Gameobject, without delay.             ----> Eins von beiden 

    //  Destroy(gameObject, 5f); // Destroy GameObject after 5 Seconds.             ----> Eins von beiden 
    //}
}
