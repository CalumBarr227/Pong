using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        int direction = Random.Range(0, 2);

        if (direction == 0)
        {
            speed = -speed;
        }

        //GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 2);


    }

    public void ResetBall()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        transform.position = Vector2.zero;
        Invoke("Start", 1f);
    }
}
