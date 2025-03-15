using UnityEngine;

public class monsterDamage : MonoBehaviour
{
    private Rigidbody2D rb;
    public CrowMovement cm;
    private Animator attackanimator;
    [SerializeField] public int damage;
    public playerHealth playerHealth;

void Start()
{
    rb = GetComponent<Rigidbody2D>();
    attackanimator = GetComponent<Animator>();
}
    
private void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.tag == "Player")
    {
        attackanimator.SetBool("IsMonsterAttacking", true);
        cm.PushCounter = cm.PushTime;
        if(collision.transform.position.x < transform.position.x)
        {
            cm.PushFromRight = true;
        }
        if(collision.transform.position.x > transform.position.x)
        {
            cm.PushFromLeft = true;
            playerHealth.TakeDamage(damage);

        }
    }
    else
    {
    attackanimator.SetBool("IsMonsterAttacking", false);
    }
 
}
}
