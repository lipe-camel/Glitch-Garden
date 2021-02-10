using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;

    Text starDisplay;

    void Start()
    {
        starDisplay = GetComponent<Text>();
        UpdateScore();
    }

    private void UpdateScore()
    {
        starDisplay.text = stars.ToString();
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateScore();
    }

    public void SpendStars(int amount)
    {
        if(HasEnough(amount))
        {
            stars -= amount;
            UpdateScore();
        }
    }

    public bool HasEnough(int amount)
    {
        return stars >= amount;
    }
}
