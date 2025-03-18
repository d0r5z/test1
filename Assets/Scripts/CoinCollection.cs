using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    public playerHealth ph;
    public int CoinsAmount = 0;
    

    private void Update()
    {
        if(CoinsAmount != 0){
            ph.health += 5 * CoinsAmount;
            CoinsAmount = 0;
        }
    }

}
