using UnityEngine;

public class PlayerCoinCollector : MonoBehaviour
{
    private int coinCount = 0;

    public void CollectCoin()
    {
        coinCount++;

        PlayerObserverManager.NotifyCoinCollected(coinCount);
    }
}