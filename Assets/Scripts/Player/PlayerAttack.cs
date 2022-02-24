using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Weapon _activeWeapon;
    private Weapon _secondaryWeapon;

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetMouseButtonDown(0))
            {
                _activeWeapon.Attack();
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                ChangeWeapon();
            }
        }
    }

    public void ChangeWeapon()
    { 
        var weapon = _activeWeapon;
        _activeWeapon = _secondaryWeapon;
        _secondaryWeapon = weapon;
    }
}
