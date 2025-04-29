using UnityEngine;
using UnityEngine.AI;

public class Enemy : Character
{
    public bool _isPlayerInView = false;
    public NavMeshAgent _agent;

    private State _currentState;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _currentState = new Idle(this, _agent);
    }

    private void FixedUpdate()
    {
        _currentState = _currentState.Process();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Attack!");
        }
    }

    // New IsGrounded method
    public bool IsGrounded()
    {
        // Perform a raycast downwards to check if the enemy is on the ground
        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }

    public bool ShouldJump()
    {
        // Check if the player is higher than the enemy
        Transform playerTransform = PlayerController.Instance.transform; // Assuming PlayerController has a singleton instance
        return playerTransform.position.y > transform.position.y + 0.5f; // Add a threshold (e.g., 1.0f) to avoid unnecessary jumps
    }
    
}