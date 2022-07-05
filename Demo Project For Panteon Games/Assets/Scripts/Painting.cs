using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    [SerializeField] GameObject brush;
    [SerializeField] float _brushSize;


    void Update()
    {

        if (Input.GetMouseButton(0))
        {

            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(Ray, out hit) && hit.collider.tag == "paintWall")
            {
                var go = Instantiate(brush, hit.point - Vector3.forward * 0.005f, hit.collider.transform.rotation);
                go.transform.localScale = Vector3.one*_brushSize;
            }

        }
    }
}