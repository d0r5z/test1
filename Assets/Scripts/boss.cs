using UnityEngine;
using UnityEngine.SceneManagement;
public class boss : MonoBehaviour
{
    public monsterHealth monsterHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(monsterHealth <= 0)
        {
            SceneManager.LoadScene(23);
        }
    }
}
