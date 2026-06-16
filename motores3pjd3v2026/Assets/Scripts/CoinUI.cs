using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text coinText;

    private void OnEnable()
    {
        PlayerOM.OnCoinCollected += UpdateCoins;
    }

    private void OnDisable()
    {
        PlayerOM.OnCoinCollected -= UpdateCoins;
    }

    private void Start()
    {
        coinText.text = "Moedas: 0";
    }

    private void UpdateCoins(int amount)
    {
        coinText.text = "Moedas: " + amount;
    }
}