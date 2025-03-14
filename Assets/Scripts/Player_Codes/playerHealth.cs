using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    private Rigidbody2D rb;
    public int MaxHealth = 10;
    public int health;
    public Image healthBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = MaxHealth;
    
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / MaxHealth, 0, 1);
    }


public void TakeDamage(int damage) 
    {
        health -= damage;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
