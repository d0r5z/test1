using UnityEngine;

public class RotateCameraOnCollision : MonoBehaviour
{
    public Camera mainCamera;
    public bool portalActivated = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (mainCamera != null)
            {
                mainCamera.transform.Rotate(0, 0, 180);
            }
            portalActivated = true;
            gameObject.SetActive(false);
        }
    }
}