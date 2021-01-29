using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Projectile projectile;
    [SerializeField] GameObject projectilePosition;
    public void Fire()
    {
        Instantiate(projectile, projectilePosition.transform.position, Quaternion.identity);
    }
}
