using UnityEngine;

public class CrowMovementAttack : MonoBehaviour
{
    [SerializeField] public float PushSpeed;
    public float PushTime;
    public float PushCounter;
    public bool PushFromRight;
    public bool PushFromLeft;
    private int Direction;
    private Rigidbody2D rb;
    public GameObject projectile;
    public GameObject projectilelewo;
    public Transform shotPoint;
    private Animator _animator;
    private float timeBtwShots;
    public float startTimeBtwShots;
    public bool FacingRight;
    public bool FacingLeft;
    [SerializeField] private bool CanGoRight;
    [SerializeField] private bool CanGoLeft;
    [SerializeField] public float Speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        FacingRight = false;
        FacingLeft = false;
        CanGoRight = true;
        CanGoLeft = true;
    }
    void Update() 
    {
         Direction = 0;
        if(CanGoRight == true)
        {if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Direction = 1;
            FacingLeft = false;
            FacingRight = true;
            CanGoLeft = false;
        }
        else { CanGoLeft = true; }
        }
        if(CanGoLeft == true)
        {if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Direction = -1;
            FacingRight = false;
            FacingLeft = true;
            CanGoRight = false;
        }

        else{ CanGoRight = true; }
        }
        
        if (FacingLeft == true)
        {
            if (timeBtwShots <= 0)
            {
                if (Input.GetMouseButtonDown(0)) 
                {
                    Instantiate(projectilelewo, shotPoint.position, transform.rotation);
                    timeBtwShots = startTimeBtwShots;
                }
            }
            else 
            {
               timeBtwShots -= Time.deltaTime;
            }
        }


        
        if (FacingRight == true)
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

        rb.linearVelocity = new Vector2(Direction * Speed, rb.linearVelocity.y);

        _animator.SetBool("IsWalking", Direction != 0);

    }

}