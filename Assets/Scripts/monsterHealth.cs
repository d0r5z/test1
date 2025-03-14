using UnityEngine;
using UnityEngine.UI;

public class monsterHealth : MonoBehaviour
{
    public int MaxMonsterHealth = 10;
    public int Monsterhealth;
    public Image MonsterhealthBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Monsterhealth = MaxMonsterHealth;
    }

    // Update is called once per frame
    void Update()
    {
        MonsterhealthBar.fillAmount = Mathf.Clamp(Monsterhealth / MaxMonsterHealth, 0, 1);
    }

public void TakeMonsterDamage(int damage) 
    {
        Monsterhealth -= damage;
        if(Monsterhealth <= 0)
        {
            Destroy(gameObject);
        }
    }

}
