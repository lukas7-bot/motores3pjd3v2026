using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        PlayerCoinCollector collector = other.GetComponent<PlayerCoinCollector>();

        if (collector != null)
        {
            collector.CollectCoin();
            Destroy(gameObject);
        }
    }
}