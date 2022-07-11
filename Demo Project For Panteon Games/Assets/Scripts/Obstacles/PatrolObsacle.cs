using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolObsacle: MonoBehaviour
{
    [SerializeField] private float patrolSpeed = 2.0f;
    public Transform point1;
    public Transform point2;

    //patrolling between point1 and point2.
    IEnumerator Start()
    {
        Transform target = point1;
        while(true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, patrolSpeed * Time.deltaTime);
            if(Vector3.Distance(transform.position,target.position)<=0)
            {
                target = target == point1 ? point2 : point1;
                yield return new WaitForSeconds(0.5f);
            }
            yield return null;
        }
    }

}
