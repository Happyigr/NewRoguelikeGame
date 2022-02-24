using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    [SerializeField] protected Weapon ActiveWeapon;
    [SerializeField] private int _health;

    public Player Target => _target;
    private Player _target;

    public void Init(Player target)
    {
        _target = target;
    }

    public void GiveWeapon(Weapon weapon)
    {
        ActiveWeapon = weapon;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
