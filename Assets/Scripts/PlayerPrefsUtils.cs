using UnityEngine;

public static class PlayerPrefsUtils
{
    private const string Orientation = "Orientation";

    public static bool IsPortrait()
    {
        return PlayerPrefs.GetInt(Orientation, 1) == 1;
    }

    public static bool HasOrientation()
    {
        return PlayerPrefs.HasKey(Orientation);
    }

    public static void SavePortrait(bool isPortrait)
    {
        PlayerPrefs.SetInt(Orientation, isPortrait ? 1 : 0);
    }
}