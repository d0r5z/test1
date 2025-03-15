using UnityEngine;
using UnityEngine.SceneManagement;
public class cutscene : MonoBehaviour
{
    public void Cut()
    {
        SceneManager.LoadScene(2);
    }
}
