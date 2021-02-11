using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Projectile projectile;
    [SerializeField] Vector3 projectilePosition;
    AttackerSpawner myLaneSpawner;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        SetLaneSpawner();
    }

    private void Update()
    {

        if (IsAttackerOnLane())
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawners)
        {
            bool isMyLane = (Mathf.RoundToInt(spawner.transform.position.y) - Mathf.RoundToInt(transform.position.y) == 0);

            if (isMyLane)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerOnLane()
    {
        return myLaneSpawner.transform.childCount > 0;
    }

    public void Fire() //acessed my animator controller
    {
        Projectile myProjectile = Instantiate(projectile, transform.position + projectilePosition, Quaternion.identity);
        myProjectile.transform.parent = transform;
    }
}
