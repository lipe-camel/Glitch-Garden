using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour
{
    [SerializeField] int lifes = 5;
    Text text;

    private void Start()
    {
        lifes -= PlayerPrefsController.GetDifficulty();
        text = GetComponent<Text>();
        UpdateLifes();
    }

    private void UpdateLifes()
    {
        text.text = "Lifes: " + lifes;
    }

    public void LoseALife()
    {
        lifes--;
        UpdateLifes();
        if (lifes <= 0) { FindObjectOfType<LevelController>().GameOver(); }
    }
}
