using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed =1f, projectileRotation =1f;
    [SerializeField] int projectileDamage = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public int GetProjectileDamage()
    {
        return projectileDamage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * projectileRotation, Space.World);
        transform.Translate(Vector3.right * Time.deltaTime * projectileSpeed, Space.World);
    }
}
