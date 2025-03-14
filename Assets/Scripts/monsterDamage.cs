using UnityEngine;

public class monsterDamage : MonoBehaviour
{
    private Rigidbody2D rb;
    public CrowMovement cm;
    [SerializeField] public int damage;
    public playerHealth playerHealth;

void Start()
{
    rb = GetComponent<Rigidbody2D>();
}
    
private void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.tag == "Player")
    {
        cm.PushCounter = cm.PushTime;
        if(collision.transform.position.x < transform.position.x)
        {
            cm.PushFromRight = true;
        }
        if(collision.transform.position.x > transform.position.x)
            cm.PushFromLeft = true;
        playerHealth.TakeDamage(damage);


        }
}
 
}
