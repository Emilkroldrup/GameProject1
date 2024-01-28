using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float dashSpeed = 20f;
    public float dashDuration = 0.2f;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private bool isGrounded;
    private bool isDashing;
    private float dashEndTime;
    private int jumpCount = 0;
    private const int maxJumpCount = 1; // Allows for double jump
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    void Update()
    {

      
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        if (isGrounded) 
        {
            jumpCount = 0;
        }

        if (!isDashing)
        {
            HandleMovement();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                HandleJump();
            }
        }

        HandleDash();
    }

    private void HandleMovement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);

        if (moveX > 0 && spriteRenderer.flipX)
        {
            FlipSprite();
        }
        else if (moveX < 0 && !spriteRenderer.flipX)
        {
            FlipSprite();
        }
    }

    private void HandleJump()
    {
        if (isGrounded || jumpCount < maxJumpCount)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCount++;
        }
    }

    private void HandleDash()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && !isDashing)
        {
            StartDash();
        }

        if (Time.time >= dashEndTime && isDashing)
        {
            EndDash();
        }
    }

    private void StartDash()
    {
        isDashing = true;
        float dashDirection = Mathf.Sign(rb.velocity.x);
        if (dashDirection == 0) dashDirection = 1; // Default to right if stationary
        rb.velocity = new Vector2(dashDirection * dashSpeed, rb.velocity.y);
        dashEndTime = Time.time + dashDuration;
    }

    private void EndDash()
    {
        isDashing = false;
    }

    private void FlipSprite()
    {
        spriteRenderer.flipX = !spriteRenderer.flipX;
        transform.Rotate(0f, 180f, 0f);
    }
}
