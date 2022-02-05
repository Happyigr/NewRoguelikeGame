using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    [SerializeField]
    private int _health;

    [SerializeField]
    public int _damage;

    [SerializeField]
    private int _fireRate; // bullets pro second

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
