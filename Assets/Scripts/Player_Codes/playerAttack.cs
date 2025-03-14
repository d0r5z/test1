using UnityEngine;

public class playerAttack : MonoBehaviour
{

    public GameObject projectile;
    public Transform shotPoint;

    private float timeBtwShots;
    public float startTimeBtwShots;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButtonDown(0)) 
            {
              Instantiate(projectile, shotPoint.position, transform.rotation);
              timeBtwShots = startTimeBtwShots;
            }
        }
        else 
        {
            timeBtwShots -= Time.deltaTime;
        }

        
    }
}
