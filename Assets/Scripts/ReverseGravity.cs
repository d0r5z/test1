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
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            isUpsideDown = !isUpsideDown;

            if (isUpsideDown)
            {
                playerRigidbody.gravityScale = -1; 
                jumpForce = -20;
                transform.Rotate(0, 180, 0);
                
                
            }
            else
            {
                playerRigidbody.gravityScale = 1; 
                jumpForce = 20;
                transform.Rotate(0, 180, 0);
                
            }
        }
    }

    void FixedUpdate()
    {

    }
}