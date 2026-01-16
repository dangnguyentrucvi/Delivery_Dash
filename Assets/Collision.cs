using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collision2D collision)
    {
        Debug.Log("Wth was that?")
    }
}
