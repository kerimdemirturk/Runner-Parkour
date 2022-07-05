using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float playerSpeed = 1.0f;
    public Rigidbody rb;
    private Vector3 startPos = new Vector3(0.102f, 3.97f, -0.269f);

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);
    }


    //if player collides obstacles turnback start point
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            transform.position = startPos;
        }
    }



}

