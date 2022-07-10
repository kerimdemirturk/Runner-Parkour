using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    [SerializeField]private float rotateSpeed = 0.2f;
    
    void Update()
    {
        transform.Rotate(0, 0, 1*rotateSpeed); 
    }
}
