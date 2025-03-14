using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private float moveInput;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

        if (moveInput > 0)
            spriteRenderer.flipX = false; // Face right
        else if (moveInput < 0)
            spriteRenderer.flipX = true; // Face left

        if (Input.GetKeyDown(KeyCode.C)) transform.Rotate(0, 0, 180);
    }
}