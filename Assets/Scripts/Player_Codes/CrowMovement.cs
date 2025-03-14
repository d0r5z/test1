using UnityEngine;

public class CrowMovement : MonoBehaviour
{
    private float Direction;
    private Rigidbody2D rb;
    [SerializeField] private float Speed;

    void Start()
    {rb = GetComponent<Rigidbody2D>();}
    void Update()
    {
        Direction = Input.GetAxis("Horizontal");
        Direction = Direction * Speed;
        rb.linearVelocity = new Vector2(Direction, rb.linearVelocity.y);
    }
}