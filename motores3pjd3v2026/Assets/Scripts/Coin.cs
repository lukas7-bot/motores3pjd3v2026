using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerCollector player = other.GetComponent<PlayerCollector>();

        if (player != null)
        {
            player.CollectCoin();
            Destroy(gameObject);
        }
    }
}