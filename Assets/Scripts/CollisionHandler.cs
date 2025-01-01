using System;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    
    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            meshRenderer.material.color = Color.red;
        }
    }

    private void OnValidate()
    {
        if (meshRenderer == null)
        {
            meshRenderer = GetComponent<MeshRenderer>();
        }
    }
}
