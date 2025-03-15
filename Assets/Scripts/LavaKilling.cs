using UnityEngine;
using UnityEngine.SceneManagement;
public class LavaKilling : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private LayerMask Lava;

    [SerializeField] private GameObject Checker;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Physics2D.OverlapCircle(Checker.transform.position, 0.2f, Lava))
        SceneManager.LoadScene(1);

    }
}
