using System;
using UnityEngine;

public class ObjectDropper : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private MeshRenderer meshRenderer;

    [SerializeField] private float timeToWait = 3;
    
    void Start()
    {
        rb.useGravity = false;
        meshRenderer.enabled = false;
    }
    
    void Update()
    {
       DropObject();
    }

    // Make obstacles visible and drop them after time has passed
    private void DropObject()
    {
        if (Time.time > timeToWait)
        {
           rb.useGravity = true;
           meshRenderer.enabled = true;
        }
    }

    private void OnValidate()
    {
        if (Application.isPlaying)
        {
            return;
        }
        
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }

        if (meshRenderer == null)
        {
            meshRenderer = GetComponent<MeshRenderer>();
        }
    }
}
