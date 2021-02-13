using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour
{
    [SerializeField] int lifes = 3;
    Text text;

    private void Start()
    {
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
        if (lifes <= 0) { Lose(); }
    }

    private void Lose()
    {
        FindObjectOfType<SceneLoader>().LoadStartScene();
    }
}
