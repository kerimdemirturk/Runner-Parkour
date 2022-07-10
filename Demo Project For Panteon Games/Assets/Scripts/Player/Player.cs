using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 1.0f;

    public Rigidbody rb;
    public Animator anim;
    public float jumpforce = 0.1f;
    private bool isHurt = false;
    private float minimumY = 7.0f;
    private GameObject startPoint;

    public  void Awake()
    {
        Vector3 startPos = transform.position;
        startPoint = GameObject.Find("startPoint");

    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    public void Update()
    {
        float playerPozZ = transform.position.z;
        if(transform.position.y<minimumY)
        {
            transform.position = startPoint.transform.position;
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            anim.SetBool("Falling", true);
        }
    }
    */
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            isHurt = true;

            if(isHurt == true)
            {
                anim.SetTrigger("isHurting");
                //rb.AddForce(0, 0, -jumpforce, ForceMode.Impulse); //bunu kaldýrýnca içinden geçiyor bnu düzeltmelisin.
            }
           



        }
    }









}
