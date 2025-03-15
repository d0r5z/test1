using UnityEngine;

public class CrowJump : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float JumpForce;
    [SerializeField] private GameObject Checker;
    [SerializeField] private LayerMask Ground;
    private Animator _animator;

    private bool isGrounded = true;

    void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
        }

    void Update()
    {
        if(Physics2D.OverlapCircle(Checker.transform.position, 0.2f, Ground))
        {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);
            _animator.SetBool("IsInAir", true);
        }
        }
        else{
            _animator.SetBool("IsInAir", false);
        }


    }
}