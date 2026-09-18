using UnityEngine;
using TMPro;

public class VictoryUIManager : MonoBehaviour
{
    [Header("Tela de Vitória")]
    [SerializeField] private GameObject winPanel;
    [SerializeField] private TextMeshProUGUI winText;

    // Propriedades públicas para acesso externo mantendo o encapsulamento
    public GameObject WinPanel => winPanel;
    public TextMeshProUGUI WinText => winText;

    private void Start()
    {
        // Desativa o painel ao iniciar a cena
        if (winPanel != null)
        {
            winPanel.SetActive(false);
        }

        // Registra esta UI no GameManager persistente
        if (GameManager.Instance != null)
        {
            GameManager.Instance.RegistrarUI(this);
        }
    }
}