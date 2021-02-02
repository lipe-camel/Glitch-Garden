using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    float movementSpeed = 1f; //acessed by animation event
    [SerializeField] int health = 100;


    public void SetMovementSpeed(float speed)
    {
        movementSpeed = speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int damage = collision.gameObject.GetComponent<Projectile>().GetProjectileDamage();
        Debug.Log(damage);
        health -= damage;
        if (health <= 0)
        {
            ManageDeath();
        }
    }

    private void ManageDeath()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * movementSpeed, Space.Self);
    }
}
