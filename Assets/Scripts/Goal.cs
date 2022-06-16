using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool IsPlayer1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (!IsPlayer1)
            {
                Debug.Log("Player1 Scored...");
                GameObject.Find("Game Manager").GetComponent<GameManager>().Player1Scored(); 
            }
            else
            {
                Debug.Log("Player2 Scored...");
                GameObject.Find("Game Manager").GetComponent<GameManager>().Player2Scored();
            }
        }   
    }
}
