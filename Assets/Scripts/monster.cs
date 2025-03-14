using UnityEngine;

public class monster : MonoBehaviour
{
    public GameObject player;
    [SerializeField] public float MonsterSpeed;
    [SerializeField] private float Distance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if(Distance < 10)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, MonsterSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }
}
