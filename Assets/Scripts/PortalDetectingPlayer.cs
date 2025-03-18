using UnityEngine;
using UnityEngine.SceneManagement;
public class PortalDetectingPlayer : MonoBehaviour
{
    public RotateCameraOnCollision roc;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (roc.portalActivated == true)
        if (other.gameObject.CompareTag("Player"))
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
