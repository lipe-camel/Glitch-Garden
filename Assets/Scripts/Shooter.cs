using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Projectile projectile;
    [SerializeField] Vector3 projectilePosition;
    public void Fire()
    {
        Instantiate(projectile, transform.position + projectilePosition, Quaternion.identity);
    }
}
