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

    int[] scores;

    // Start is called before the first frame update
    void Start()
    {
        //Dummy data
        scores = new int[5] { 100,20,30,41,311};
        //scores = new int[5];
        LoadScoreboard();
    }

    public void LoadScoreboard()
    {
        StringBuilder text = new StringBuilder();
        Array.Sort(scores);
        text.AppendLine("Scoreboard:");
        int point = 1;
        for(int i = scores.Length - 1; i >= 0; i--)
        {
            text.AppendLine($"{point}° - {scores[i]}");
            point++;
        }
        scoreBoard.text = text.ToString();
    }

    public void UpdateScoreBoard(int newScore)
    {
        Array.Sort(scores);
        bool canBeUpdated = false;
        for (int i = 0; i < scores.Length; i++)
        {
            if (!canBeUpdated)
            {

            }
            else
            {

            }
        }
    }
}
