using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tk.Players
{
    public class CameraRotation : MonoBehaviour
    {
        [SerializeField] private Transform pivotH, pivotV;
        [SerializeField] private float sensH, sensV;
        [SerializeField] private float maxVR, minVR;
        [SerializeField] private bool verticalInverted;
        void Start()
        {

        }


        void Update()
        {
            float horizontal = Input.GetAxis("Mouse X");
            float vertical = Input.GetAxis("Mouse Y");

            horizontal *= 1 + sensH;
            vertical *= (1 + sensV);
            vertical *= verticalInverted ? -1 : 1;
            vertical = CheckLimits(vertical);

            pivotH.Rotate(Vector3.up * horizontal);
            pivotV.Rotate(Vector3.right * vertical);
        }


        float CheckLimits( float value)
        {
            float result = value;

            if(value != 0) {
                
                float expect = pivotV.rotation.eulerAngles.x + value;

                if(!(expect > 360 + minVR || expect < maxVR))
                {
                    result = 0;
                }
            }

            return result;
        }
    }

}