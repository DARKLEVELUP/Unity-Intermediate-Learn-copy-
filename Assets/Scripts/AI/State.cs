using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class State
{
    public UnityEvent OnStateChange;
    public enum STATE
    {
        IDLE,
        PATROL
    }
    public enum EVENT
    {
        ENTER,
        UPDATE,
        EXIT
    }
    public STATE Name;
    protected EVENT Stage;
    protected State NextState;

    protected Enemy Me;
    protected NavMeshAgent Agent;

    public State(Enemy character, NavMeshAgent agent)
    {
        Me = character;
        Agent = agent;

        Stage = EVENT.ENTER;
    }

    public virtual void Enter()
    {
        Stage = EVENT.UPDATE;
        Debug.Log($"Enter {Name} state.");
    }

    public virtual void Update()
    {
        Stage = EVENT.UPDATE;
    }

    public virtual void Exit()
    {
        Stage = EVENT.EXIT;
        Debug.Log($"Exit {Name} state.");
    }

    public State Process()
    {
        if (Stage == EVENT.ENTER)
        {
            Enter();
        }
        else if (Stage == EVENT.UPDATE)
        {
            Update();
        }
        else if (Stage == EVENT.EXIT)
        {
            Exit();
            OnStateChange?.Invoke();
            return NextState;
        }
        return this;
    }
}
