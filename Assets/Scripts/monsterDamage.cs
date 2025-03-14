using UnityEngine;

public class monsterDamage : MonoBehaviour
{

    [SerializeField] public float damage;
    public playerHealth playerHealth;

    
    
private void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.tag == "Player")
    {
        playerHealth.TakeDamage(damage);
        
    }
}
 
}
