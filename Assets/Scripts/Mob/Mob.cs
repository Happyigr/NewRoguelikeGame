using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    [SerializeField]
    protected Weapon Weapon;

    [SerializeField]
    private int _health;

    [SerializeField]
    private int _damage;

    [SerializeField]
    private int _fireRate; // bullets pro second

    public Player Target => _target;
    private Player _target;

    public void Init(Player target)
    {
        _target = target;
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("is hurted");
        _health -= damage;
        if (_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("is died");
    }
}
