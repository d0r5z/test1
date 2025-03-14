using UnityEngine;

public class CameraFlip2D : MonoBehaviour
{
    private bool isUpsideDown = false;
    private Rigidbody2D playerRigidbody;
    public float jumpForce = 10f;
    private float originalJumpForce;

    void Start()
    {
        playerRigidbody = FindObjectOfType<Rigidbody2D>();
        originalJumpForce = jumpForce;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            isUpsideDown = !isUpsideDown;

            if (isUpsideDown)
            {
                playerRigidbody.gravityScale = -1; 
                jumpForce = -originalJumpForce; 
                
            }
            else
            {
                playerRigidbody.gravityScale = 1; 
                jumpForce = originalJumpForce; 
                
            }
        }
    }

    void FixedUpdate()
    {
        if (playerRigidbody != null)
        {
            playerRigidbody.rotation = 0f; // Keep the player's rotation fixed (always facing upright)
        }
    }
}