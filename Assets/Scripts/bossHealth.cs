using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bossHealth : MonoBehaviour
{
    [SerializeField] public float MaxBossHealth = 10;
    [SerializeField] public float Bosshealth;
    [SerializeField] public Image BosshealthBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Bosshealth = MaxBossHealth;
    }

    // Update is called once per frame
    void Update()
    {
        BosshealthBar.fillAmount = Mathf.Clamp(Bosshealth / MaxBossHealth, 0, 1);
    }

public void TakeMonsterDamage(float damage) 
    {
        Bosshealth -= damage;
        if(Bosshealth <= 0)
        {
            SceneManager.LoadScene(23);
        }
    }

}