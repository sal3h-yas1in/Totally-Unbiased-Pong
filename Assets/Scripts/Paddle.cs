using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public bool isAI;
    public float speed;
    public GameObject Ball;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    private float movement;
    private float distance;
    private Vector3 move;

    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1 && !isAI)
        {
            movement = Input.GetAxisRaw("Vertical1");
        }
        else if (!isPlayer1 && !isAI)
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);

        if (isAI)
        {
            distance = Mathf.Floor(Ball.transform.position.y - rb.position.y);
            if (distance - 0.85 > 0)
            {
                if (rb.transform.position.y < 3.35)
                {
                    rb.AddForce(transform.up * speed, ForceMode2D.Impulse);
                }
            }
            if (distance + 0.85 < 0)
            {
                if (rb.transform.position.y > -3.35)
                {
                    rb.AddForce(-1 * transform.up * speed, ForceMode2D.Impulse);
                }
            }
        }
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
