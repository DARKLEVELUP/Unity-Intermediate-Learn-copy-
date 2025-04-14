using UnityEngine;

public class Items : MonoBehaviour, ICollectable
{
    public void Collect()
    {
        Debug.Log("Items Collected");
        Destroy(gameObject);
    }
}
