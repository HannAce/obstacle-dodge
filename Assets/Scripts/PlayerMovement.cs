using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float xMoveSpeed = 0f;
    private float yMoveSpeed = 0.1f;
    private float zMoveSpeed = 0f;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Translate(xMoveSpeed, yMoveSpeed * Time.deltaTime, zMoveSpeed);
    }
}
