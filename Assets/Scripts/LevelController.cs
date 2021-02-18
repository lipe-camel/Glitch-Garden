using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winScreen;
    [SerializeField] GameObject loseScreen;
    [SerializeField] float timeToLoad = 2f;
    int numberOfAttackers;
    bool isGameOver = false;
    GameTimer gameTimer;
    AttackerSpawner[] spawners;

    void Start()
    {
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
        gameTimer = FindObjectOfType<GameTimer>();
        spawners = FindObjectsOfType<AttackerSpawner>();
        Time.timeScale = 1;
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
            winScreen.SetActive(true);
            isGameOver = true;
            FindObjectOfType<SceneLoader>().Invoke("LoadStartScene", timeToLoad);
        }
    }

    internal bool IsGameOver()
    {
        return isGameOver;
    }

    public void GameOver()
    {
        loseScreen.SetActive(true);
        Time.timeScale = 0;
        isGameOver = true;
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
