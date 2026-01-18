using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool hasPackage;
    [SerializeField] private float destroyDelay = 1f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        // if  (the tag is package)
        // then (print "pickeup package to console)
        if (collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Picked up package");
            hasPackage = true;
            Destroy(collision.gameObject, destroyDelay);
        }

        else if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivery package");
            hasPackage = false;
        }
    }
}
