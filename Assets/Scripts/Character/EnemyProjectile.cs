using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float TrueDamage;

    private void OnCollisionEnter(Collision other)
    {
        print(other.transform.name + "," + other.transform.root.name);

        if (other.transform.root.TryGetComponent(out IDamageable hitTarget))
        {
            hitTarget.TakeDamage(TrueDamage);
        }
    }
}
