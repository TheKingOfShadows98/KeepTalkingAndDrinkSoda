using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Tk.Players
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] float speed;
        [SerializeField] Rigidbody rig;
        [SerializeField] Transform floorPoint;
        [SerializeField] float rayDistance;
        [SerializeField] float jumpForce;

        /*TODO
        *
        *-Añadir animaciones
        *
        */
        void FixedUpdate()
        {
            Vector3 vel = transform.forward * (speed * Input.GetAxisRaw("Vertical"));
            vel += transform.right * (speed * Input.GetAxisRaw("Horizontal"));
            vel += Vector3.up * rig.velocity.y;
            rig.velocity = vel;
            Ray ray = new Ray(floorPoint.position, Vector3.down);

            bool inground = Physics.Raycast(ray, rayDistance);

            if (inground && Input.GetButton("Jump"))
            {
                rig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
