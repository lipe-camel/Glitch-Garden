using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] Defender defender;
    StarDisplay starDisplay;


    private void Start()
    {
        starDisplay = FindObjectOfType<StarDisplay>();
    }


    //Spawn
    private void OnMouseDown()
    {
        if (!defender) { return; }
        AttemptToSpawn(GetSquareClicked());
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    private void SpawnDefender(Vector2 worldPos)
    {
        starDisplay.SpendStars(defender.GetStarCost()); 
        Defender newDefender = Instantiate(defender, worldPos, defender.transform.rotation);
    }

    private void AttemptToSpawn(Vector2 worldPos)
    {
        if (starDisplay.HasEnough(defender.GetStarCost()))
        {
            SpawnDefender(worldPos);
        }
    }


    //Calculate Spawn Position
    private Vector2 GetSquareClicked()
    {
        var mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        var worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        var gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

}
