using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker[] attackers;

    bool spawn = true;

    private IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        int randomAttacker = Random.Range(0, attackers.Length);
        Spawn(randomAttacker);
    }

    private void Spawn(int randomAttacker)
    {
        Attacker newAttacker = Instantiate(attackers[randomAttacker], transform.position, transform.rotation);
        newAttacker.transform.parent = transform;
    }
}
