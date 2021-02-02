using UnityEngine;

public class Attacker : MonoBehaviour
{
    float movementSpeed = 1f; //acessed by animation event

    public void SetMovementSpeed(float speed)
    {
        movementSpeed = speed;
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * movementSpeed, Space.Self);
    }
}
