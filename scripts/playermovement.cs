using UnityEngine;

public class playermovement : MonoBehaviour
{
    [SerializeField] float jumpForce = 18f;
    [SerializeField] float runSpeed = 5f;
    float dirX;
    Rigidbody2D rb;
    BoxCollider2D playerCollider2D; // Renamed to playerCollider2D
    [SerializeField] LayerMask groundmask;
    SpriteRenderer spriteRenderer;
    Animator animator;
    bool gamePaused = false;
    [SerializeField] AudioSource jumpAudio;

    private enum Movementstate { Idle, Run, Jump, Fall }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerCollider2D = GetComponent<BoxCollider2D>();  // Use the renamed variable here
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");

        // Handle Jumping
        if (Input.GetKeyDown(KeyCode.Space) && iSGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); // Only apply vertical velocity change
            jumpAudio.Play();
        }

        // Handle Animations
        HandleAnimation();

        // Handle Pause functionality
        PauseGame();
    }

    void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Pause when Escape key is pressed
        {
            gamePaused = !gamePaused;
        }

        if (gamePaused)
        {
            Time.timeScale = 0f;  // Stop time (pauses the game)
            AudioListener.pause = true; // Pause all audio
        }
        else
        {
            Time.timeScale = 1f;  // Resume time
            AudioListener.pause = false; // Unpause audio
        }
    }

    // FixedUpdate is used for physics updates, like movement
    private void FixedUpdate()
    {
        // Apply horizontal movement (keep vertical velocity unchanged)
        rb.linearVelocity = new Vector2(dirX * runSpeed * Time.deltaTime, rb.linearVelocity.y);
    }

    // Check if the player is grounded (touching the ground)
    bool iSGrounded()
    {
        return Physics2D.BoxCast(playerCollider2D.bounds.center, playerCollider2D.bounds.size, 0, Vector2.down, 0.1f, groundmask);
    }

    // Handle player animation based on movement state
    void HandleAnimation()
    {
        Movementstate state;

        // Check running direction
        if (dirX > 0)
        {
            spriteRenderer.flipX = false; // Face right
            state = Movementstate.Run;
        }
        else if (dirX < 0)
        {
            spriteRenderer.flipX = true; // Face left
            state = Movementstate.Run;
        }
        else
        {
            state = Movementstate.Idle; // Idle if no horizontal input
        }

        // Check if player is jumping or falling
        if (rb.linearVelocity.y > 0.1f)
        {
            state = Movementstate.Jump;
        }
        else if (rb.linearVelocity.y < -0.1f)
        {
            state = Movementstate.Fall;
        }

        // Set the animator's integer value for movement state
        animator.SetInteger("state", (int)state);
    }
}
