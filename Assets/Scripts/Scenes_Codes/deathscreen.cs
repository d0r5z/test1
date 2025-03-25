using UnityEngine;
using UnityEngine.SceneManagement;
public class deathscreen : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

}
