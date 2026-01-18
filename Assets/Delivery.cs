using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // if  (the tag is package)
        // then (print "picked up package to console)
        if (collision.CompareTag("Package"))
        {
            Debug.Log("Pickup package");
        }

        else if (collision.CompareTag("Customer"))
        {
            Debug.Log("Delivery package");
        }
    }
}
