using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomizeMovement : MonoBehaviour
{
   
    public GameObject[] randomObjects;

    private GameObject StartPoint;
    private Rigidbody enemyRB;
    private float spawnPointX = 1.17f;
    private Vector3 tempDest;


    void Start()
    {

        
        enemyRB = GetComponent<Rigidbody>();
        StartPoint = GameObject.Find("startPoint");
        NavMeshAgent navMesh = GetComponent<NavMeshAgent>();


        //give a destination to navmesh agent for creating a illusion. 
        int randomizeObject›ndex = Random.Range(0, randomObjects.Length);
        navMesh.destination = randomObjects[randomizeObject›ndex].transform.position;
        tempDest = navMesh.destination;

    }


    void Update()
    {
        if (transform.position == tempDest)
        {
            enemyRB.velocity = Vector3.zero;
        }
    }



    //when collide with obstacle start from zero.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            transform.position = new Vector3(Random.Range(-spawnPointX, spawnPointX), StartPoint.transform.position.y, StartPoint.transform.position.z);
        }
        
    }
  
}

