using UnityEngine;

public class weapon : MonoBehaviour
{

    public float offset;

    public GameObject projectile;
    public Transform shotPoint;
    private float timeBtwShots;
    private SpriteRenderer spriteRenderer;
    private float moveInput;
    public float startTimeBtwShots;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if(timeBtwShots <= 0)
        {
            if(Input.GetMouseButtonDown(0))
            {
                Instantiate(projectile, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
        }
        else{
            timeBtwShots -= Time.deltaTime;
        }
        moveInput = Input.GetAxis("Horizontal");

        if (moveInput > 0)
            spriteRenderer.flipX = false;
        else if (moveInput < 0)
            spriteRenderer.flipX = true;
        
    }
   
}
