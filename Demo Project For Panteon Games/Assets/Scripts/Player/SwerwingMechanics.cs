using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerwingMechanics : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f/10;
    private Vector3 swipefirstPos;
    private Vector3 swipeSecondPozition;
    private Vector3 currentSwipe;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))//first touch moment
        {
            swipefirstPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))//while we clicking
        {
            swipeSecondPozition = Input.mousePosition;
            float distanceX = swipeSecondPozition.x - swipefirstPos.x;
            transform.Translate(distanceX * Time.deltaTime * speed, 0, 0);
        }
        if (Input.GetMouseButtonUp(0))
        {
            swipefirstPos = Vector3.zero;
            swipeSecondPozition = Vector3.zero;
        }
    }
}
