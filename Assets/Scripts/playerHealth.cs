using UnityEngine;

public class playerHealth : MonoBehaviour
{

    public int MaxHealth = 10;
    public int health;
    private Rigidbody2D rb;
    [SerializeField] public float PushForce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = MaxHealth;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


public void TakeDamage(int damage) 
    {
        health -= damage;
        rb.linearVelocity = new Vector2(PushForce, rb.linearVelocity.y);
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
