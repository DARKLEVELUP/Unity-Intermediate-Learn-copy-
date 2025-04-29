using UnityEngine;
using UnityEngine.AI;

public class Enemy : Character
{
    public bool _isPlayerInView = false;
    public NavMeshAgent _agent;

    private State _currentState;

    private void Awake()
    {
        _currentState = new Idle(this, _agent);
    }


    private void FixedUpdate()
    {
        _currentState = _currentState.Process();
    }
}
