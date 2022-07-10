using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolllow : MonoBehaviour
{
    //Determine to following object(player) position.
    public Transform player;
    public float cameraSpeed;
    public Vector3 cameraPosOffset;

    void Start()
    {
        
    }

    //follow player with smootly.
    void LateUpdate()
    {
        Vector3 playerPos = player.position+cameraPosOffset;
        Vector3 camPos = transform.position;
        Vector3 followPosition = Vector3.Lerp(camPos,playerPos,cameraSpeed);
        transform.position = followPosition;


       
    }
}
