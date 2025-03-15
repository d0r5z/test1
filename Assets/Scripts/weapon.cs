using UnityEngine;

public class weapon : MonoBehaviour
{

    public float offset;

    public GameObject projectile;
    public Transform shotPoint;
    private float timeBtwShots;
    private Animator _animator;
    public float startTimeBtwShots;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _animator = GetComponent<Animator>();
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
                _animator.SetBool("IsShooting", true);
            }
        }
        else{
            timeBtwShots -= Time.deltaTime;
        }

        
    }
    public void StopShoot()
    {
        _animator.SetBool("IsShooting", false);
    }
}
