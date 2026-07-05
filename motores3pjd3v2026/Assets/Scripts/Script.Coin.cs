using UnityEngine;

public class Coin : MonoBehaviour
{
    private static int coins = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AddCoin();
            Destroy(gameObject);
        }
    }

    private void AddCoin()
    {
        coins++;

        Debug.Log("Moedas: " + coins);

        PlayerObserverManager.NotifyCoinsChanged(coins);
    }
}