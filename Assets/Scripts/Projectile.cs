using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed =1f, projectileRotation =1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * projectileRotation, Space.World);
        transform.Translate(Vector3.right * Time.deltaTime * projectileSpeed, Space.World);
    }
}
