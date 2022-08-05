using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCheck : MonoBehaviour
{
    private void Update()
    {

        Ray ray;
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                
                Debug.Log(hit.point);
            }
        }
    }
}