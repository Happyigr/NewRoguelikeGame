using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoveOrStayState : State
{
    [SerializeField] private float _forcePower;

    private Vector2 _moveDirection;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        if (Random.Range(0, 2) == 1)
            _moveDirection = new Vector2(0, 0);
        else
            _moveDirection = new Vector2(Random.Range(0f, 1f), Random.Range(0f, 1f));

        _rb.velocity = new Vector3(0, 0, 0);
        _rb.AddForce(_moveDirection * _forcePower);
    }

    private void OnDisable()
    {
        _rb.velocity = new Vector3(0, 0, 0);
    }
}
