using UnityEngine;
using UnityEngine.AI;

public class Patrol : State
{
    public Patrol(Enemy character, NavMeshAgent agent) : base(character, agent)
    {
        Name = STATE.PATROL;
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Update()
    {
        base.Update();
        Agent.SetDestination(PlayerController.Instance.transform.position);
        if (Me._isPlayerInView && Me.ShouldJump()) // Hypothetical condition for jumping
        {
            NextState = new Jump(Me, Agent, new Idle(Me, Agent)); // Jump and then transition to Idle
            Stage = EVENT.EXIT;
        }
    }

    public override void Exit()
    {   
        Agent.ResetPath();
        base.Exit();
    }
}
