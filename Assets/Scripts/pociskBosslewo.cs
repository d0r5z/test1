using UnityEngine;

public class PociskBosslewo : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float damage;

    public float ProjectileDistance;
    public LayerMask whatIsSolid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, -transform.right, ProjectileDistance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            if(hitInfo.collider.CompareTag("Enemy"))
            {
                Debug.Log("ENEMY MUST TAKE DAMAGE !");
                hitInfo.collider.GetComponent<bossHealth>().TakeMonsterDamage(damage);
            }
            DestroyProjectile();
        }

        transform.Translate(-transform.right * speed * Time.deltaTime);
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}

