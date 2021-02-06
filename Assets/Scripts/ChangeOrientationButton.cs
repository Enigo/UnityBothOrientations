using UnityEngine;

public class ChangeOrientationButton : MonoBehaviour
{
    public void ChangeOrientation()
    {
        if (Screen.orientation == ScreenOrientation.Portrait)
        {
            Screen.orientation = ScreenOrientation.Landscape;
            PlayerPrefsUtils.SavePortrait(false);
        }
        else
        {
            Screen.orientation = ScreenOrientation.Portrait;
            PlayerPrefsUtils.SavePortrait(true);
        }
    }
}