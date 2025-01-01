using UnityEngine;

public class ObjectSpinner : MonoBehaviour
{
    [SerializeField] private float xRotateSpeed;
    [SerializeField] private float zRotateSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateObject();
    }

    private void RotateObject()
    {
        transform.Rotate(xRotateSpeed * Time.deltaTime,0, zRotateSpeed * Time.deltaTime);
    }
}
