using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bonk!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("j z tr?");
    }
}
