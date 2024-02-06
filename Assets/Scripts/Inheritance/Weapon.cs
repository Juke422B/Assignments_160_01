using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    protected string weaponName;
    protected int weaponStrength;

    protected string WeaponName { get => weaponName; set => weaponName = value; }
    protected int WeaponStrength { get => weaponStrength; set => weaponStrength = value; }
    protected virtual void TakeDamage(int damage)
    {
        weaponStrength -= damage; //weaponStrength = weaponStrength - damage;
    }
}
