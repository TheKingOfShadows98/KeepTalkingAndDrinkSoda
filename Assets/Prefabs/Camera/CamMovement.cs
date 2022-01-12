using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    [SerializeField] Transform Head;
    [SerializeField] Transform Cam;
    [SerializeField] float speed;
    [SerializeField] float sensivityX;

    [SerializeField] float sensivityY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X");
        x *= sensivityX;
        Head.Rotate(Vector3.up * x);
        float y = Input.GetAxis("Mouse Y");
        y *= sensivityY;
        Cam.Rotate(Vector3.right * -y);

        float forward = Input.GetAxis("Vertical");
        float right = Input.GetAxis("Horizontal");
        forward *= Time.deltaTime * speed;
        right *= Time.deltaTime * speed;
        Head.position += Cam.forward * forward;
        Head.position += Cam.right * right;
    }
}
