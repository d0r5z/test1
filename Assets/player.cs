using UnityEngine;

public class player : MonoBehaviour
{

    private Rigidbody2D rb;
    private float moveDirection;
    [SerializeField] private float playerSpeed = 5f;
    [SerializeField] private float jumpForce;
    [SerializeField] private GameObject groundCheck;
    [SerializeField] private LayerMask GroundLayer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = Input.GetAxis("Horizontal");
        moveDirection = moveDirection * playerSpeed;
        rb.linearVelocity = new Vector2(moveDirection, rb.linearVelocity.y);
        if (Physics2D.OverlapCircle(groundCheck.transform.position, 0.2f, GroundLayer))
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
        
    }
}
