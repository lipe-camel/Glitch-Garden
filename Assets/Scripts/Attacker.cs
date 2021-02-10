using UnityEngine;

public class Attacker : MonoBehaviour
{
    float movementSpeed = 1f; //acessed by animation event

    public void SetMovementSpeed(float speed) //acessed by animation event
    {
        movementSpeed = speed;
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * movementSpeed, Space.Self);
    }
}
