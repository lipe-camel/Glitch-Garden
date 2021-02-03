using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;

    private Vector2 GetSquareClicked()
    {
        var mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        var worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        return worldPos;
    }

    private void OnMouseDown()
    {
        GameObject newDefender = Instantiate(defender, GetSquareClicked(), Quaternion.identity) as GameObject;
    }

}
