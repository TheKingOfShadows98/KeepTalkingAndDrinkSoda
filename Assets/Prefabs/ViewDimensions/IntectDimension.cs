using UnityEngine;

namespace Tk.Dimensions
{
    public class IntectDimension : MonoBehaviour
    {
        [SerializeField] private string maskDimension;
        [SerializeField] private bool active;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (active)
                {
                    CameraAddCullingMask.instance.AddCullingMask(maskDimension);
                }
                else
                {
                    CameraAddCullingMask.instance.RemoveCullingMask(maskDimension);
                }
                Physics.IgnoreLayerCollision(3, LayerMask.NameToLayer(maskDimension), !active);
            }
            /*
             * _OLD
             *
                if (other.CompareTag("Player"))
                {
                    if (active)
                    {
                        CameraAddCullingMask.instance.AddCullingMask(maskDimension);
                    }
                    else
                    {
                        CameraAddCullingMask.instance.RemoveCullingMask(maskDimension);
                    }
                    Physics.IgnoreLayerCollision(3, LayerMask.NameToLayer(maskDimension), !active);
                }
             */
        }
    }
}