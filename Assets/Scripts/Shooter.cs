using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Projectile projectile;
    [SerializeField] Vector3 projectilePosition;
    AttackerSpawner myLaneSpawner;

    private void Start()
    {
        SetLaneSpawner();
    }

    private void Update()
    {
        if (IsAttackerOnLane())
        {
            //change animation state to shooting
        }
        else
        {
            //change animation state to idle
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
        Instantiate(projectile, transform.position + projectilePosition, Quaternion.identity);
    }
}
