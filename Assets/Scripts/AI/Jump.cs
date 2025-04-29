using UnityEngine;
using UnityEngine.AI;

public class Jump : State
{
    private State _nextState; // Store the next state dynamically

    public Jump(Enemy character, NavMeshAgent agent, State nextState) : base(character, agent)
    {
        Name = STATE.JUMP;
        _nextState = nextState; // Assign the next state dynamically
    }

public override void Enter()
{
    base.Enter();
    Debug.Log($"Enter {Name} state.");
    
    // Ensure the Rigidbody is not null
    if (Me._rigidbody != null)
    {
        Me._rigidbody.linearVelocity = Vector3.zero; // Reset velocity to avoid stacking forces
        Me._rigidbody.AddForce(Vector3.up * Me._jumpForce, ForceMode.Impulse);
        Debug.Log("JUMPING!");
    }
    else
    {
        Debug.LogError("Rigidbody is missing on the enemy!");
    }
}

    public override void Update()
    {
        base.Update();
        if (Me.IsGrounded()) // Check if the character has landed
        {
            NextState = _nextState; // Transition to the dynamically assigned next state
            Stage = EVENT.EXIT;
        }
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log($"Exit {Name} state.");
    }
}