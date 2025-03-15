using UnityEngine;

public class CameraRotateOnPortal : MonoBehaviour
{
    public float rotationAngle = 90f;  // Rotation angle in degrees
    public float rotationSpeed = 5f;   // Speed of rotation
    public Transform playerTransform;  // Reference to player (for teleporting)
    public Transform teleportLocation; // Where the player should teleport after rotation

    private float targetZRotation;
    private bool shouldRotate = false;

    void Start()
    {
        targetZRotation = transform.eulerAngles.z; // Get initial rotation
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Portal") && !shouldRotate)
        {
            targetZRotation += rotationAngle; // Rotate around Z-axis
            shouldRotate = true;

            // Optional: Teleport player after a short delay
            Invoke(nameof(TeleportPlayer), 0.5f);
        }
    }

    void Update()
    {
        if (shouldRotate)
        {
            // Smoothly interpolate rotation
            float newZ = Mathf.LerpAngle(transform.eulerAngles.z, targetZRotation, Time.deltaTime * rotationSpeed);
            transform.rotation = Quaternion.Euler(0, 0, newZ);

            // Stop rotating when close to target angle
            if (Mathf.DeltaAngle(transform.eulerAngles.z, targetZRotation) < 0.1f)
            {
                transform.rotation = Quaternion.Euler(0, 0, targetZRotation);
                shouldRotate = false;
            }
        }
    }

    void TeleportPlayer()
    {
        if (playerTransform != null && teleportLocation != null)
        {
            playerTransform.position = teleportLocation.position; // Move player to new position
        }
    }
}