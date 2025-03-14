using UnityEngine;
using TMPro;
public class CoinCollection : MonoBehaviour
{
    
    public int CoinsAmount = 0;
    public TMP_Text noteText;

    private void Update()
    {
        noteText.text = "COINS: " + CoinsAmount.ToString();
    }

}
