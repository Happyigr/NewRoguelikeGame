using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    [SerializeField]
    private State _firstState;

    private Player _target;
    private State _currentState;

    public State Current => _currentState;

    private void Start()
    {
        _target = GetComponent<Mob>().Target;

        Init();
    }

    private void Update()
    {
        if (_currentState == null)
            return;

        var next = _currentState.GetNextState();
        if (next != null)
            SetState(next);
    }

    private void Init()
    {
        _currentState = _firstState;
    }

    private void SetState(State state)
    {
        if(_currentState != null)
            _currentState.Exit();
        
        _currentState = state;

        if (_currentState != null)
            _currentState.Enter(_target);
    }
}
