using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField]
    protected int Damage;

    [SerializeField]
    protected float FireRate; // attacks in second

    [SerializeField]
    private WeaponType _type;

    protected float LastHitTime;

    public abstract void Attack();

    public WeaponType GetWeaponType()
    {
        return _type;
    }
}
