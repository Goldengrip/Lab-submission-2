using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileObject : Weapon
{
    [SerializeField]
    private Projectile projectile;

    [SerializeField]
    private Transform firePoint;

    protected override void Attack(float chargePercent)
    {
        Projectile current = Instantiate(projectile, firePoint.position, owner.transform.rotation);

        current.Initialize(chargePercent, owner);
    }
}
