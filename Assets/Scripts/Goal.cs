using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool leftGoal = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            GameManager gameManager = FindObjectOfType<GameManager>();

            if (leftGoal == true)
            {
                gameManager.RightPlayerScore();
            }
            else
            {
                gameManager.LeftPlayerScore();
            }
        }
        collision.transform.position = Vector2.zero;
    }
}
