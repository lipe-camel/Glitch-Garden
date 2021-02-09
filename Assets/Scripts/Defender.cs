using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [Header("Transform")]
    public Vector2 spawnOffset;
    [Header("Resource")]
    [SerializeField] int starCost = 100;
}
