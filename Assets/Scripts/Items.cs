using Unity.Mathematics;
using UnityEngine;
using PrimeTween;

public class Items : MonoBehaviour, ICollectable
{
    [SerializeField]public float rotationSpeed = 0.05f;

        private void Update()
    {
        transform.rotation *= quaternion.Euler(0, rotationSpeed, 0);
    }

    public void Collect()
    {
        Debug.Log("Items Collected");
        Destroy(gameObject);
    }
}
