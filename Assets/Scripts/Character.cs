using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] public Rigidbody _rigidbody;
    [SerializeField] public Animator _animator;

    protected float _speed;
    public float _jumpForce = 10f;
    protected Vector2 _movementInput;
    protected virtual void Movement()
    {
        
    }
}
