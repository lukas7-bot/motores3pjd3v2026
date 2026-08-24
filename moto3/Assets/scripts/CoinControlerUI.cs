using TMPro;
using UnityEngine;

public class CoinControlerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;

    private void OnEnable()
    {
        PlayerObserverManager.OnMoedaCollected += UpdateCoinText;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnMoedaCollected -= UpdateCoinText;
    }

    private void Start()
    {
        if (coinText != null)
        {
            coinText.text = "Moedas: 0";
        }
    }

    private void UpdateCoinText(int totalMoedas)
    {
        if (coinText != null)
        {
            coinText.text = "Moedas: " + totalMoedas;
        }
    }
}