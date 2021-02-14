using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;

    public Rigidbody rb;

    private float MoveX;

    public bool canMove;

    public bool onRightLane;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        onRightLane = true;
        canMove = false;
    }

    void Update()
    {
        if (canMove)
        {
            MoveX = Input.GetAxisRaw("Horizontal");
        }

        // Right
        if (MoveX > 0 && !onRightLane)
        {
            Vector3 rightPosition = new Vector3(transform.position.x, transform.position.y, 0f);
            transform.position = rightPosition;

            onRightLane = true;
        }

        if (MoveX < 0 && onRightLane)
        {
            Vector3 leftPosition = new Vector3(transform.position.x, transform.position.y, 4f);
            transform.position = leftPosition;

            onRightLane = false;
        }
    }

    private void FixedUpdate()
    {
        if (canMove)
        {
            rb.AddForce(transform.right * speed * Time.deltaTime * 100f);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }

}
