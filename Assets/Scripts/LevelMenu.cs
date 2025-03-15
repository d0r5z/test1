using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelMenu : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene(3);
    }
    public void Scene2()
    {
        SceneManager.LoadScene(5);
    }



}
