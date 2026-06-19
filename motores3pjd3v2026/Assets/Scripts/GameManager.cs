using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public enum GameState
    {
        Iniciando,
        MenuPrincipal,
        Gameplay
    }

    public GameState CurrentState;

    [Header("Input")]
    public PlayerInput playerInput;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        ChangeState(GameState.Iniciando);

        StartCoroutine(LoadSceneFlow("GetStarted_Scene"));
    }

    public void ChangeState(GameState newState)
    {
        CurrentState = newState;
        Debug.Log("Estado atual: " + CurrentState);
    }

    public void LoadScene(string sceneName)
    {
        StartCoroutine(LoadSceneFlow(sceneName));
    }

    private IEnumerator LoadSceneFlow(string sceneName)
    {
        Debug.Log("Carregando cena: " + sceneName);

        AsyncOperation loadOp = SceneManager.LoadSceneAsync(sceneName);
        while (!loadOp.isDone)
        {
            yield return null;
        }

        switch (sceneName)
        {
            case "Splash":
                ChangeState(GameState.Iniciando);
                break;

            case "MenuPrincipal":
                ChangeState(GameState.MenuPrincipal);
                break;

            case "GetStarted_Scene":
                ChangeState(GameState.Gameplay);

                AllocateInput();

                Debug.Log("Tentando carregar GUI");

                yield return new WaitForSeconds(0.1f);

                SceneManager.LoadScene("GUI", LoadSceneMode.Additive);
                break;
        }
    }

    void AllocateInput()
    {
        if (playerInput != null)
        {
            Debug.Log("Input alocado ao jogador.");
        }
        else
        {
            Debug.LogWarning("PlayerInput não encontrado!");
        }
    }

    public void StartGame()
    {
        LoadScene("GetStarted_Scene");
    }

    public void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}