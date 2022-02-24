using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected int Damage;
    [SerializeField] protected float FireRate; // attacks in second
    [SerializeField] private WeaponType _type;

    protected float LastHitTime;

    private Animator _anim;

    private void OnEnable()
    {
        _anim = GetComponent<Animator>();
    }

    public abstract void Attack();

    public WeaponType GetWeaponType()
    {
        return _type;
    }
}
