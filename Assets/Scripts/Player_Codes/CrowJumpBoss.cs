using UnityEngine;

public class CrowJumpBoss : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float JumpForce;



    void Start()
        {rb = GetComponent<Rigidbody2D>();}

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);
        

    }
}