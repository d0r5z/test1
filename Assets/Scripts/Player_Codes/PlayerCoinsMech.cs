using UnityEngine;

public class PlayerCoinsMech : MonoBehaviour
{
    public CoinCollection CC;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("coins"))
        {
            CC.CoinsAmount = CC.CoinsAmount + 1;
            Destroy(other.gameObject);
        }
    }
}