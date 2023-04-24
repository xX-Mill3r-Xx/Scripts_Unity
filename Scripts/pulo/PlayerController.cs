using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public int extraJumps = 1;

    private Rigidbody2D rb;
    private bool isGrounded;
    private int extraJumpsValue;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        extraJumpsValue = extraJumps;
    }

    void Update()
    {
        // Verificar se está no chão
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        // Movimento horizontal
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * moveSpeed, rb.velocity.y);

        // Pulo
        if (isGrounded)
            extraJumpsValue = extraJumps;

        if (Input.GetKeyDown(KeyCode.Space) && extraJumpsValue > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            extraJumpsValue--;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && extraJumpsValue == 0 && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
