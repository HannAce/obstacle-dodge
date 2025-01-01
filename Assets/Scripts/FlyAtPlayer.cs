using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 playerPos;
    
    [SerializeField] private float projectileSpeed;
    
    void Start()
    {
       playerPos = player.transform.position; 
    }
    
    void Update()
    {
        MoveToPlayer();
    }

    private void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, projectileSpeed * Time.deltaTime);
        if (transform.position == playerPos)
        {
            DestroySelf();
        }
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
