using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed =1f, projectileRotation =1f;
    [SerializeField] int projectileDamage = 20;


    public int GetProjectileDamage()
    {
        return projectileDamage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var health = collision.GetComponent<Health>();
        var attacker = collision.GetComponent<Attacker>();
        if(health && attacker)
        {
            health.DealDamage(projectileDamage);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * projectileRotation, Space.World);
        transform.Translate(Vector3.right * Time.deltaTime * projectileSpeed, Space.World);
    }
}
