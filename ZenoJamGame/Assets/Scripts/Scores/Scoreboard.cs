using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoreBoard;

    List<int> scores;

    void Start()
    {
        //Dummy data
        scores = new List<int> { 0,0,0,0,0};
        //scores = new List<int>();
        LoadScoreboard();
    }

    public void LoadScoreboard()
    {
        StringBuilder text = new StringBuilder();
        scores.Sort();
        scores.Reverse();
        text.AppendLine("Scoreboard:");
        int point = 1;
        for(int i = 0; i < scores.Count; i++)
        {
            text.AppendLine($"{point}° - {scores[i]}");
            point++;
        }
        scoreBoard.text = text.ToString();
    }

    public void UpdateScoreBoard(int newScore)
    {
        scores.Add(newScore);
        scores.Sort();
        scores.Reverse();
        scores.RemoveAt(scores.Count- 1);
        LoadScoreboard();
    }
}
