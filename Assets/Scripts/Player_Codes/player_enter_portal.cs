using UnityEngine;

public class player_enter_portal : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float flipSpeed = 2f;

    private bool isUpsideDown = false;
    private bool isFlipping = false;
    private Quaternion targetRotation;
    void Start()
    {
        targetRotation = transform.rotation;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {   if(other.gameObject.CompareTag("Portal"))
        {
            isUpsideDown = !isUpsideDown;
            isFlipping = true;

            float newZRotation = isUpsideDown ? 180f : 0f;
            targetRotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, newZRotation);
        }

        if (isFlipping)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, flipSpeed * 100 * Time.deltaTime);

            if (Quaternion.Angle(transform.rotation, targetRotation) < 0.1f)
            {
                transform.rotation = targetRotation;
                isFlipping = false;
            }
        }
    }
}