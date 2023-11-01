using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    public float health { get; set; }

    public void Die();

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            Die();
        }
    }
}
