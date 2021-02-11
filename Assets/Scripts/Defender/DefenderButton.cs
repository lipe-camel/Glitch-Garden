using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;

    Color32 greyedColor;

    private void Start()
    {
        greyedColor = GetComponent<SpriteRenderer>().color;
    }

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = greyedColor;
        }
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

}
