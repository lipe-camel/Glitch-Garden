using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;

    public void DealDamage(int damage)
    {
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
}
