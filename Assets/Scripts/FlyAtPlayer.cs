using System;
using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 playerPos;
    
    [SerializeField] private float projectileSpeed;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    { 
        playerPos = player.transform.position; 
    }
    
    void Update()
    {
        MoveToPlayer();
        DestroySelf();
    }

    private void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, projectileSpeed * Time.deltaTime);
    }

    private void DestroySelf()
    {
        if (transform.position == playerPos)
        {
            Destroy(gameObject);
        }
    }
}
