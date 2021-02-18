using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    LevelController levelController;

    Color32 greyedColor;

    private void Start()
    {
        greyedColor = GetComponent<SpriteRenderer>().color;
        levelController = FindObjectOfType<LevelController>();
        LabelStarCost();
    }

    private void LabelStarCost()
    {
        Text defenderCostDisplay = GetComponentInChildren<Text>();
        defenderCostDisplay.text = defenderPrefab.GetStarCost().ToString();
    }

    private void OnMouseDown()
    {
        if (levelController.IsGameOver()) { return; }
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = greyedColor;
        }
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

}
