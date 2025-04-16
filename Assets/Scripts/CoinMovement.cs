using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public float floatSpeed = 1f;
    public float floatHeight = 0.5f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        
        // Rotate around the object's up axis (local Y)
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    
        // Float up and down smoothly
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
