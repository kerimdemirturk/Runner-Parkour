using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] Vector3 moveBorder;
    [SerializeField] float obstacleSpeed=1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0);
        transform.Translate(Vector3.right * obstacleSpeed * Time.deltaTime);
        if(transform.position.x>moveBorder.x)
        {
            transform.Translate(Vector3.left * obstacleSpeed * Time.deltaTime);
        }
        

    }
}
