using System;

public static class PlayerObserverManager
{
    public static Action<int> OnCoinsChanged;

    public static void UpdateCoins(int coins)
    {
        OnCoinsChanged?.Invoke(coins);
    }
}


