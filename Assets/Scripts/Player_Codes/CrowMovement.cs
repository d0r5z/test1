using UnityEngine;

public class CrowMovement : MonoBehaviour
{
    [SerializeField] public float PushSpeed;
    public float PushTime;
    public float PushCounter;
    public bool PushFromRight;
    public bool PushFromLeft;
    public float Direction;
    private Rigidbody2D rb;
    private Animator _animator;
    [SerializeField] private float Speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        Direction = Input.GetAxis("Horizontal");
        Direction = Direction * Speed;
        if(PushCounter <= 0)
        {rb.linearVelocity = new Vector2(Direction, rb.linearVelocity.y);
        PushFromLeft = false;
        PushFromRight = false;}

        else{
            if(PushFromRight == true)
            {
                rb.linearVelocity = new Vector2(-PushSpeed, PushSpeed / 10);
            }
            if(PushFromLeft == true)
            {
                rb.linearVelocity = new Vector2(PushSpeed, PushSpeed / 10);
            }
            PushCounter -= Time.deltaTime;
        }
        _animator.SetBool("IsWalking", Direction != 0);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        Direction = Direction * PushSpeed;
    }
}