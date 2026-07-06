using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    private int coins = 0;

    private void Start()
    {
        PlayerObserverManager.UpdateCoins(coins);
    }

    public void CollectCoin()
    {
        coins++;

        PlayerObserverManager.UpdateCoins(coins);

        Debug.Log("Moedas: " + coins);
    }
}