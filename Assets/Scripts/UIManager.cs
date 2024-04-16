using System;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMP_Text ScorePanel;
    
    public int Score { get; set; }

    public Action<int> UpdateScore;

    private void OnEnable()
    {
        UpdateScore += OnUpdateScore;
    }

    private void OnUpdateScore(int score)
    {
        Score += score;
        ScorePanel.text = "Score: " + Score;
    }
}
