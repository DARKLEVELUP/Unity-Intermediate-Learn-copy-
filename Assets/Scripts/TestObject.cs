using UnityEngine;

public class TestObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(PlayerController.Instance._jumpForce);
    }


}
