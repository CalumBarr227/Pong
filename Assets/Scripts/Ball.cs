using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;
    public AudioClip paddleSound;
    public AudioClip wallSound;
    AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        int direction = Random.Range(0, 2);

        if (direction == 0)
        {
            rb.velocity = new Vector2(-speed, Random.Range(-2f, 2f));
        }
        else
        {
            rb.velocity = new Vector2(speed, Random.Range(-2f, 2f));
        }
    }
            //GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
            //GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 2);

    public void ResetBall()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        transform.position = Vector2.zero;
        Invoke("Start", 1f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            audioSource.PlayOneShot(paddleSound);
            float difference = transform.position.y - collision.transform.position.y;

            if(collision.transform.position.x > 0)
            {
                rb.velocity = new Vector2(-speed, difference * 3);
            }
            else
            {
                rb.velocity = new Vector2(speed, difference * 3);
            }
        }
        else if(collision.gameObject.CompareTag("Wall"))
        {
            audioSource.PlayOneShot(wallSound);
        }
    }
}