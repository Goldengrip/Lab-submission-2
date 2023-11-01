using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;

    public LayerMask groundLayer, playerLayer;

    private Rigidbody enemy;
    public Vector3 walkPoint;

    private bool walkPointMet = false;

    public float walkPointRange;

    public bool playerInSightRange, playerInAttackRange;

    public float sightRange, attackRange;

    public GameObject projectileObject;

    public GameObject projectilePosition;

    public float timeBetweenAttacks;

    private bool alreadyAttacked;

    private void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, playerLayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, playerLayer);

        if (playerInSightRange && playerInAttackRange)
        {
            Attack();
        }
    }

    public void Attack()
    {
        transform.LookAt(player);

        if (!alreadyAttacked)
        {
            Rigidbody rb = Instantiate(projectileObject, projectilePosition.transform.position,
                Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 1f, ForceMode.Impulse);

            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    public void ResetAttack()
    {
        alreadyAttacked = false;
    }
}
