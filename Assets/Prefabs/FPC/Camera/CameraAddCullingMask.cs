using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAddCullingMask : MonoBehaviour
{
    public static CameraAddCullingMask instance;
    [SerializeField] private List<string> VisualLayers;
    [SerializeField] Camera cam;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
        cam = Camera.main;
        UpdateCullingMaks();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateCullingMaks()
    {
        cam.cullingMask = LayerMask.GetMask(VisualLayers.ToArray());
    }

    public void AddCullingMask(string mask)
    {
        if (!VisualLayers.Contains(mask))
        {
            VisualLayers.Add(mask);
            UpdateCullingMaks();
        }
    }
    public void RemoveCullingMask(string mask)
    {
        if (VisualLayers.Contains(mask))
        {
            VisualLayers.Remove(mask);
            UpdateCullingMaks();
        }
    }
}
