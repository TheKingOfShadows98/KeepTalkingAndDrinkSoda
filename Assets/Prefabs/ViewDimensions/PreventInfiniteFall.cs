using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventInfiniteFall : MonoBehaviour
{
    [SerializeField] GameObject spawn;
    [SerializeField] float distanceToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y <= distanceToSpawn)
        {
            transform.position = spawn.transform.position;
        }
    }
}
