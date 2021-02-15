using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int numberOfAttackers;
    GameTimer gameTimer;
    AttackerSpawner[] spawners;

    void Start()
    {
        gameTimer = FindObjectOfType<GameTimer>();
        spawners = FindObjectsOfType<AttackerSpawner>();
    }

    public void AttackerSpawned()
    {
        numberOfAttackers++;
        Debug.Log(numberOfAttackers);
    }

    public void AttackerKilled()
    {
        numberOfAttackers--;
        Debug.Log(numberOfAttackers);
        CheckForEndOfLevel();
    }

    private void CheckForEndOfLevel()
    {
        if (gameTimer.GetTimerFinished() && numberOfAttackers <= 0)
        {
            Debug.Log("You Win!!!");
        }
    }

    public void StopSpawners()
    {
        foreach (AttackerSpawner spawner in spawners)
        {
            spawner.StopSpawning();
            spawner.StopAllCoroutines();
        }
    }
}
