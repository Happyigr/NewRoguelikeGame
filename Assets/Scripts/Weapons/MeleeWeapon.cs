using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : Weapon
{
    [SerializeField] private GameObject _attackPoint; // Point that will be a center of hit circle
    [SerializeField] private float _attackRange;
    [SerializeField] private LayerMask _layer;

    public override void Attack()
    {
        if (Time.time - LastHitTime >= FireRate)
        {
            Collider2D[] hittedEnemyes = Physics2D.OverlapCircleAll(_attackPoint.transform.position, _attackRange, _layer);
            if (hittedEnemyes != null)
            {
                foreach (var hit in hittedEnemyes)
                {
                    if (hit.TryGetComponent<Mob>(out Mob mob))
                    {
                        mob.TakeDamage(Damage);
                    }
                }

                LastHitTime = Time.time;
            }
        }

        else
        {
            Debug.Log("cooldown");
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (_attackPoint != null)
            Gizmos.DrawWireSphere(_attackPoint.transform.position, _attackRange);
    }
}
