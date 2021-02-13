using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    Attacker attacker;
    Animator animator;


    private void Start()
    {
        attacker = GetComponent<Attacker>();
        animator = GetComponent<Animator>();
        animator.SetBool("hasJumped", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherObject = collision.gameObject;
        if (otherObject.GetComponent<Tank>() && animator.GetBool("hasJumped") == false)
        {
            animator.SetTrigger("Jump");
            animator.SetBool("hasJumped", true);
        }
        else if (otherObject.GetComponent<Defender>())
        {
            attacker.Attack(otherObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject otherObject = collision.gameObject;
        if (otherObject.GetComponent<Defender>())
        {
            Debug.Log(gameObject.name + " exited defender collision");
            attacker.UpdateAnimationState();
        }
    }
}
