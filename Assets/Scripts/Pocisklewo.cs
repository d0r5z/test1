using UnityEngine;

public class Pocisklewo : MonoBehaviour
{
     public float speedlewo;
    public float lifeTimelewo;
    public float damage;

    public float ProjectileDistancelewo;
    public LayerMask whatIsSolidlewo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("DestroyProjectile", lifeTimelewo);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, -transform.right, ProjectileDistancelewo, whatIsSolidlewo);
        if (hitInfo.collider != null)
        {
            if(hitInfo.collider.CompareTag("Enemy"))
            {
                Debug.Log("ENEMY MUST TAKE DAMAGE !");
                hitInfo.collider.GetComponent<monsterHealth>().TakeMonsterDamage(damage);
            }
            DestroyProjectile();
        }

        transform.Translate(-transform.right * speedlewo * Time.deltaTime);
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
