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
            if(leftGoal == true)
            {
                Debug.Log("Right Player Scored!");
            }
            else
            {
                Debug.Log("Left Player Scored!");
            }
        }
        collision.transform.position = Vector2.zero;
    }
}
