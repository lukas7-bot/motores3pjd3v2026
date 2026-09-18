using System.Collections;
using UnityEngine;

public class SplashScreenLoader : MonoBehaviour
{
    [SerializeField] private float displayDuration = 2f;
    [SerializeField] private string targetSceneName = "Menu";

    private void Start()
    {
        StartCoroutine(WaitAndLoadMenu());
    }

    private IEnumerator WaitAndLoadMenu()
    {
        yield return new WaitForSeconds(displayDuration);
        
        if (GameManager.Instance != null)
        {
            GameManager.Instance.RequestSceneChange(targetSceneName);
        }
    }
}