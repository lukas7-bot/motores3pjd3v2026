using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerCoins playerCoins =
            other.GetComponentInParent<PlayerCoins>();

        if(playerCoins != null)
        {
            playerCoins.AddCoin();
            Destroy(gameObject);
        }
    }
}