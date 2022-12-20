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
        scores = new int[5];

        LoadScoreboard();
    }

    public void LoadScoreboard()
    {
        StringBuilder text = new StringBuilder();
        text.Append("Scoreboard:");

        //text.AppendLine
    }

    public void UpdateScoreBoard(int newScore)
    {

    }
}
