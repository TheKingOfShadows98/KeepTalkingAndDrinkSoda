using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToucherCC : MonoBehaviour
{
    public float range = 1;
    public LayerMask layers;
    
    private void SendRay( string info)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 zone = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray.origin, ray.direction, out hit, range, layers))
        {
            try
            {

                hit.collider.GetComponent<TouchAbleObject>().reciveTouchEvent(info);
            }
            catch
            {
               
            }
        }
    }

    private void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            SendRay("pressed");
        }
    }
}
