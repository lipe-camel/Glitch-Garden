using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeLoser : MonoBehaviour
{
    LifeDisplay lifeDisplay;

    void Start()
    {
        lifeDisplay = FindObjectOfType<LifeDisplay>();
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherObject = collision.gameObject;
        if (otherObject.GetComponent<Attacker>())
        {
            lifeDisplay.LoseALife();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject otherObject = collision.gameObject;
        if (otherObject.GetComponent<Attacker>())
        {
            Destroy(otherObject);
        }

    }

}
