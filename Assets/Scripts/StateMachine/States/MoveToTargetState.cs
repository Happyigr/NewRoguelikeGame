using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTargetState : State
{
    [SerializeField] private float _forcePower;

    private float _xSpeedInProcents;
    private float _ySpeedInProcents;

    private float _yD; // distance between Mob and PLayer on x axis
    private float _xD; // distance between Mob and PLayer on y axis

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _yD = Target.transform.position.y - transform.position.y;
        _xD = Target.transform.position.x - transform.position.x;

        float xySum = Mathf.Abs(_yD) + Mathf.Abs(_xD);

        if (_xD != 0)
            _xSpeedInProcents = _xD / xySum;
        if(_yD != 0)
            _ySpeedInProcents = _yD / xySum;

        Vector2 moveVectors = new Vector2(_xSpeedInProcents, _ySpeedInProcents);

        _rb.velocity = new Vector3(0, 0, 0);
        _rb.AddForce(moveVectors * _forcePower);
    }
}
