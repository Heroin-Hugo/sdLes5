using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int coinAmount;
    [SerializeField] private TextMeshProUGUI coinText;
    private void Start()
    {
        CoinPickup.onCoinPickup += AddCoin;
    }

    private void AddCoin()
    {
        coinAmount++;
        if(coinText != null) coinText.text = $"COINS: {coinAmount}";
    }
}
