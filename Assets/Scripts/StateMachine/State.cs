using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    [SerializeField]
    private Condition[] _conditions;

    protected Player Target;

    public void Enter(Player target)
    {
        if(enabled == false)
        {
            Target = target;
            enabled = true;
            foreach (var condition in _conditions)
            {
                condition.Enter(Target);
            }
        }
    }

    public void Exit()
    {
        if(enabled == true)
        {
            foreach (var con in _conditions)
            {
                con.Exit();
            }

            enabled = false;
        }
    }

    public State GetNextState()
    {
        foreach (var condition in _conditions)
        {
            if (condition.NeedTransit)
                return condition.TargetState;
        }

        return null;
    }
}
