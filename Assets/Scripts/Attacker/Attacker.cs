﻿using System;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    float movementSpeed = 1f; //acessed by animation event
    [SerializeField] int damage = 20;
    GameObject currentTarget;
    Animator animator;
    LevelController levelController;

    private void Awake()
    {
        levelController = FindObjectOfType<LevelController>();
        levelController.AttackerSpawned();
    }

    private void OnDestroy()
    {
        if (!levelController) { return; }
        levelController.AttackerKilled();
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * movementSpeed, Space.Self);
    }

    public void UpdateAnimationState()
    {
        animator.SetBool("isAttacking", false);
    }

    public void SetMovementSpeed(float speed) //acessed by animation event
    {
        movementSpeed = speed;
    }

    public void Attack(GameObject target)
    {
        animator.SetBool("isAttacking", true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget()
    {
        if (!currentTarget) { return; }
        Health health = currentTarget.GetComponent<Health>();
        if (health)
        {
            health.DealDamage(damage);
        }
    }
}