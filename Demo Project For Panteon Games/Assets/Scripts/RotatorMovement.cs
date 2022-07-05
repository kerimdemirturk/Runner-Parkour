using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorMovement : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 0.1f;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0, 1 * rotateSpeed, 0);
    }
}
