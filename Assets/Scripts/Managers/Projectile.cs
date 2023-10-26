using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float curSpeed;
    private float curDamage;
    private Vector3 curDirection;
    private float contactDamage;
    private Rigidbody owner;
    private float lifeTime;

    public void Initialize(float chargePercent, Rigidbody owner)
    {
        this.owner = owner;
        curDirection = transform.right;
        curSpeed = chargePercent;
        curDamage = contactDamage * chargePercent;
        GetComponent<Rigidbody>().AddForce(transform.forward * curSpeed, ForceMode.Impulse);
    }

}
