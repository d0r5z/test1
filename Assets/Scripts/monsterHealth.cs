using UnityEngine;

public class monsterHealth : MonoBehaviour
{
    public int MaxMonsterHealth = 10;
    public int Monsterhealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Monsterhealth = MaxMonsterHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void TakeMonsterDamage(int damage) 
    {
        Monsterhealth -= damage;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
