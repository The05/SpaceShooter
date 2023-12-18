using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    private int currentPoints = 0;
    public Text pointsText; // Reference to a UI Text element to display points

    void Start()
    {
        UpdatePointsText();
    }

    public void AddPoints(int pointsToAdd)
    {
        currentPoints += pointsToAdd;
        UpdatePointsText();
    }

    void UpdatePointsText()
    {
        if (pointsText != null)
        {
            pointsText.text = "Points: " + currentPoints.ToString();
        }
    }
}
