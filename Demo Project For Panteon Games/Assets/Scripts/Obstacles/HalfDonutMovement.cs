using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonutMovement : MonoBehaviour
{
    //donut move speed and start,finish pozition.
    [SerializeField] float donutMovement = 0.1f;
    private Vector3 startPos;
    private Vector3 finishPos;

    void Start()
    {
        //start and finish position of stick and give move distance to donut.
        Vector3 moveDistance = new Vector3(0.4f, 0, 0);
        startPos = transform.position;
        finishPos = transform.position + moveDistance;
    }

    void Update()
    {
        //moving between two point.
        transform.position = Vector3.Lerp(startPos, finishPos, Mathf.PingPong(Time.time * donutMovement, 1f));
    }


}
