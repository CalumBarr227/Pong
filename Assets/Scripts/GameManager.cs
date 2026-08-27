using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI leftScoreText;
    public TextMeshProUGUI rightScoreText;
    public GameObject winnerScreen;
    public TextMeshProUGUI winnerText;
    public bool winnerScreenActive = false;

    int leftScore = 0;
    int rightScore = 0;

    void Start()
    {
        winnerScreen.SetActive(false);
    }
    public void LeftPlayerScore()
    {
        leftScore++;
        leftScoreText.text = leftScore.ToString();

        if(leftScore >= 11)
        {
            PlayerWins("Left Player Wins!");
        }
    }

    public void RightPlayerScore()
    {
        rightScore++;
        rightScoreText.text = rightScore.ToString();

        if (rightScore >= 11)
        {
            PlayerWins("Right Player Wins!");
        }
    }

    void PlayerWins(string winner)
    {
        winnerScreenActive = true;
        winnerText.text = winner;
        winnerScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void PlayAgain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
