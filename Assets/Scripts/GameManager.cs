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
    public TextMeshProUGUI countdownText;
    int leftScore = 0;
    int rightScore = 0;
    public Ball ball;

    void Start()
    {
        winnerScreen.SetActive(false);
        StartCoroutine(Countdown());
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

    IEnumerator Countdown()
    {
        countdownText.text = "3";
        yield return new WaitForSeconds(1f);

        countdownText.text = "2";
        yield return new WaitForSeconds(1f);

        countdownText.text = "1";
        yield return new WaitForSeconds(1f);

        countdownText.text = "GO!";
        yield return new WaitForSeconds(1f);

        countdownText.text = "";

        //ball.StartBall();
    }
}
