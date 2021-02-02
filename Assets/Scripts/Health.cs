using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;
    [Header("VFX")]
    [SerializeField] GameObject deathVFX;
    [SerializeField] Vector3 deathVFXOffset;

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
        TriggerDeathVFX();
        Destroy(gameObject);
    }

    private void TriggerDeathVFX()
    {
        if (!deathVFX) { return; }
        GameObject vfx = Instantiate(deathVFX, transform.position + deathVFXOffset, Quaternion.identity);
        var duration = vfx.GetComponent<ParticleSystem>().main.startLifetime.constantMax;
        Destroy(vfx, duration);
    }
}
