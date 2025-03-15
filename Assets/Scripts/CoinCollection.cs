using UnityEngine;
using TMPro;
public class CoinCollection : MonoBehaviour
{
    public playerHealth ph;
    public int CoinsAmount = 0;
    

    private void Update()
    {
        ph.health += 5 * CoinsAmount;
        CoinsAmount = 0;
    }

}
