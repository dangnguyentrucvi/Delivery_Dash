using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.05f;
    [SerializeField] float steerSpeed = 0.5f;
    
    void Start()
    {

    }
    
    void Update()
    {
        float move = 0f;
        float steer = 0f;
        
        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }
        
        if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }
        
        transform.Translate(0, move * moveSpeed, 0);
        transform.Rotate(0, 0, steer * steerSpeed); 
       
    }
}
