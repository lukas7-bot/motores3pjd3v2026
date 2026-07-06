using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinsChanged += UpdateUI;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinsChanged -= UpdateUI;
    }

    private void UpdateUI(int amount)
    {
        coinText.text = "Moedas: " + amount;
    }
}