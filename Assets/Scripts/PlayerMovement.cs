using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D RB;
    private Vector2 moveDirection;
    private void Update()
    {
        ProccesInputs();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void ProccesInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection= new Vector2(moveX, moveY);
    }

    private void Move()
    {
        RB.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
