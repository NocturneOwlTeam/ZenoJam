using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score;

    [SerializeField]
    TextMeshProUGUI scoreText;

    [SerializeField]
    Scoreboard scoreboard;

    public int currentScore => score;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    public void UpdateScoreText() => scoreText.text = $"{score}";

    public void AddScore(int amount)
    {
        if (amount <= 0) return;
        score += amount;
        UpdateScoreText();
    }

    public void FinishedScore()
    {
        scoreboard.UpdateScoreBoard(score);
    }
}
