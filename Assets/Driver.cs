using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0.05f;
    
    void Start()
    {

    }
    
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("We r moving forward!");
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("We r moving backward!");
        }
        
        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("We r turning to the left!");
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("We r turning to the right!");
        }
        
        transform.Translate(0, moveSpeed, 0);
        transform.Rotate(0, 0, steerSpeed); 
       
    }
}
