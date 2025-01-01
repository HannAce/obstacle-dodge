using System;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other)
    {
        meshRenderer.material.color = Color.red;
    }
}
