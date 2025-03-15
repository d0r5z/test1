using UnityEngine;
using UnityEngine.SceneManagement;
public class endgame : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene(2);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Credits()
    {
        SceneManager.LoadScene(24);
    }
}
