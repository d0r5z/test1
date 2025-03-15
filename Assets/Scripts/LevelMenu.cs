using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelMenu : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene(2);
    }
    public void Scene2()
    {
        SceneManager.LoadScene(5);
    }
    public void Scene3()
    {
        SceneManager.LoadScene(8);
    }
    public void Scene4()
    {
        SceneManager.LoadScene(11);
    }
    public void Scene5()
    {
        SceneManager.LoadScene(14);
    }
    public void Scene6()
    {
        SceneManager.LoadScene(17);
    }
    public void Scene7()
    {
        SceneManager.LoadScene(20);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
