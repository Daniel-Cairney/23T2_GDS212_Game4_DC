using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    Rigidbody2D rb;
    float dirX;
    float dirY;
    float moveSpeed = 20f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        float initialTiltX = Input.acceleration.x;
        float initialTiltY = Input.acceleration.y;

        // Set the initial tilt as the starting value
        dirX = initialTiltX * moveSpeed;
        dirY = initialTiltY * moveSpeed;
    }

    private void Update()
    {
        dirX = Input.acceleration.x * moveSpeed;
        dirY = Input.acceleration.y * moveSpeed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
    }
}