using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Inventory : MonoBehaviour
{
    private Weapon _mainWeapon;
    private Weapon _secondaryWeapon;
    // private Thing[] _posions

    public void ChangeWeapon()
    {
        var weapon = _mainWeapon;
        _mainWeapon = _secondaryWeapon;
        _secondaryWeapon = weapon;

        if (TryGetComponent(out PlayerAttack playerAttack))
        {
            playerAttack.ChangeWeapon();
        }

        else if (TryGetComponent(out Mob mob))
        {
            mob.GiveWeapon(_mainWeapon);
        }
    }
}
