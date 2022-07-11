using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OpponentMovement : MonoBehaviour
{
    private GameObject destination;
    private GameObject StartPoint;
    private Rigidbody enemyRB;
    private float spawnPointX = 1.17f;

    
     void Start()
    {
       
        enemyRB = GetComponent<Rigidbody>();
        destination = GameObject.Find("destination");
        StartPoint = GameObject.Find("startPoint");

       

        NavMeshAgent navMesh = GetComponent<NavMeshAgent>();
        navMesh.destination = destination.transform.position;

    }

    
    void Update()
    {
        if(transform.position == destination.transform.position)
        {
            enemyRB.velocity = Vector3.zero;
        }
    }

    

    //when collide with obstacle start from zero.
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            transform.position = new Vector3(Random.Range(-spawnPointX,spawnPointX),StartPoint.transform.position.y,StartPoint.transform.position.z);
        }
    }
}
