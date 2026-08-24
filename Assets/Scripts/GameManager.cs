using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI leftScoreText;
    public TextMeshProUGUI rightScoreText;

    int leftScore = 0;
    int rightScore = 0;

    public void LeftPlayerScore()
    {
        leftScore++;
        leftScoreText.text = leftScore.ToString();
    }

    public void RightPlayerScore()
    {
        rightScore++;
        rightScoreText.text = rightScore.ToString();
    }
}
