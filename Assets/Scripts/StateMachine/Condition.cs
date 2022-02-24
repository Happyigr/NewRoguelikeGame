using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Condition : MonoBehaviour
{
    [SerializeField]
    private State _targetState;

    protected Player Target { get; private set; }

    public State TargetState => _targetState;

    public bool NeedTransit { get; protected set; }

    public void Enter(Player target)
    {
        Target = target;
        NeedTransit = false;
        enabled = true;
    }

    public void Exit()
    {
        NeedTransit = false;
        enabled = false;
    }
}
