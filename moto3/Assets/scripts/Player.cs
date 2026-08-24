using UnityEngine;

public class PlayerMoedaCollector : MonoBehaviour
{
    private int moedaCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Moeda"))
        {
            moedaCount++;
            
            PlayerObserverManager.NotifyMoedaCollected(moedaCount);
            
            Destroy(other.gameObject);
        }
    }
}