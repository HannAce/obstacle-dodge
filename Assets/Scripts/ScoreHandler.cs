using System;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    private int objectsHit = 0;
    private void OnCollisionEnter(Collision other)
    {
        objectsHit++;
        Debug.Log($"You've bumped into things {objectsHit} time(s).");
    }
}
