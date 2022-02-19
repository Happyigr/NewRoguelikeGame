using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class MeleeAttack : State
{
    [SerializeField] private int _damage;
    [SerializeField] private float _fireRate; // Attacks in second

    private float _lastAttackTime;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_lastAttackTime <= 0)
        {

        }
    }

    private void Attack(Player target)
    {
        _animator.Play("Attack");
        target.TakeDamage(_damage);
    }
}
