using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    
    public float MaxHealth = 10;
    public float health;
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


public void TakeDamage(float damage) 
    {
        health -= damage;
        if(health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
