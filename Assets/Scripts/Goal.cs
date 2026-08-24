using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool leftGoal = false;
    public AudioClip goalSound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            audioSource.PlayOneShot(goalSound);
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
        //collision.transform.position = Vector2.zero;
        collision.GetComponent<Ball>().ResetBall();
    }
}
