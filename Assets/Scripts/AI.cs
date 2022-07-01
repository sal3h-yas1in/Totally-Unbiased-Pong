using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float speed;
    public Rigidbody2D Ballrb;
    public Rigidbody2D MyRigidBody;
    public Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (MyRigidBody.position.y > Ballrb.position.y)
        {
            MyRigidBody.velocity = new Vector2 (MyRigidBody.velocity.x, -1 * speed);
        }
        else if (MyRigidBody.velocity.y < Ballrb.velocity.y)
        {
            MyRigidBody.velocity = new Vector2 (MyRigidBody.velocity.x, 1 * speed);
        }
    }

    public void Reset()
    {
        MyRigidBody.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
