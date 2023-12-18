using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    public static PointsManager instance;

    public Text scoreText;
    float score = 0;
    float rockAmount = 0;
    float multiplier = 1.0f;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoreText.text = score.ToString() + " Poäng";
    }


    public void AddPoint()
    {
        score += 100 * multiplier;
        scoreText.text = score.ToString() + " Poäng";
        rockAmount++;
    }
    public void UpdateMultiplier()
    {
        multiplier = 1.0f + (rockAmount / 100 ); 
    }
}
