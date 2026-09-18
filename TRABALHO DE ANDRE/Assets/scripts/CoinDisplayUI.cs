using TMPro;
using UnityEngine;

public class CoinDisplayUI : MonoBehaviour
{
    [Header("Configuração do Jogador")]
    [Tooltip("0 para Player 1 | 1 para Player 2")]
    [SerializeField] private int targetPlayerIndex = 0;

    [Header("Referência de Texto")]
    [SerializeField] private TextMeshProUGUI coinText;

    private void OnEnable()
    {
        PlayerObserverManager.OnMoedaCollected += HandleCoinCollected;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnMoedaCollected -= HandleCoinCollected;
    }

    private void Start()
    {
        UpdateText(0);
    }

    private void HandleCoinCollected(int totalMoedas)
    {
        if (GameManager.Instance != null)
        {
            int playerScore = (targetPlayerIndex == 0) ? GameManager.Instance.p1Score : GameManager.Instance.p2Score;
            UpdateText(playerScore);
        }
        else
        {
            UpdateText(totalMoedas);
        }
    }

    private void UpdateText(int value)
    {
        if (coinText != null)
        {
            string prefix = (targetPlayerIndex == 0) ? "Moedas: " : "Moedas: ";
            coinText.text = prefix + value;
        }
    }
}