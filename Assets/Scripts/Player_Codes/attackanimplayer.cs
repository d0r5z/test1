using UnityEngine;

public class attackanimplayer : MonoBehaviour
{
    private Animator _animator;
        void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
            if(Input.GetMouseButtonDown(0))
            {
                _animator.SetBool("IsShooting", true);
            }
    }  
    public void StopShoot()
    {
        _animator.SetBool("IsShooting", false);
    }

}
