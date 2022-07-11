using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 1.0f;

    public Rigidbody rb;
    public Animator anim;
    public float jumpforce = 0.1f;
    private bool isHurt = false;
    private float minimumY = 7.0f;
    private GameObject startPoint;
    private float finishLine = 20.93f;

    public  void Awake()
    {
        
        Vector3 startPos = transform.position;
        startPoint = GameObject.Find("startPoint");

    }
    public void Start()
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
        newScene();

        float posZ = transform.position.z;
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            playerSpeed = 0;
            StartCoroutine(playerSpeedZero());
            isHurt = true;
            

            if(isHurt == true)
            {
                anim.SetTrigger("isHurting");
            }

        }
    }

    public void newScene()
    {
        if (transform.position.z > finishLine)
        {
            SceneManager.LoadScene(1);
        }
    }

    
    public IEnumerator playerSpeedZero()
    {
            yield return new WaitForSeconds(2.267f);
            playerSpeed = 0.7f;
    }
    
    
   
}
