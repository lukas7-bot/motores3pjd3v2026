using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    private int coins = 0;

    public void AddCoin()
    {
        coins++;

        Debug.Log("Moedas: " + coins);

        PlayerObserverManager.NotifyCoinsChanged(coins);
    }
}