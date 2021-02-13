﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    Attacker attacker;

    private void Start()
    {
       attacker =  GetComponent<Attacker>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherObject = collision.gameObject;
        if (otherObject.GetComponent<Defender>())
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
