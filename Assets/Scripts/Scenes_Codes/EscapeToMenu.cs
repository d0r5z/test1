using UnityEngine;
using UnityEngine.SceneManagement; 

public class EscapeToMenu : MonoBehaviour
{
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }
}