using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Delivery : MonoBehaviour
{
    private bool hasPackage;
    [SerializeField] private float destroyDelay = 1;
    [SerializeField] TMP_Text pickedUpText;

    private void Start()
    {
        pickedUpText.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // if  (the tag is package)
        // then (print "picked up package" to console)
        if (collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Picked up package");
            hasPackage = true;
            pickedUpText.gameObject.SetActive(true);
            Destroy(collision.gameObject, destroyDelay);
        }

        if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivery package");
            hasPackage = false;
            pickedUpText.gameObject.SetActive(false);
            Destroy(collision.gameObject);
        }
    }
}
