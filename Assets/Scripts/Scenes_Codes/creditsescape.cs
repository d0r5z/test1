using UnityEngine;
using UnityEngine.SceneManagement; 

public class creditsescape : MonoBehaviour
{
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
        }
    }
}
