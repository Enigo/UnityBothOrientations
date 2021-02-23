using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OrientationSetter : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(SetupInitialOrientation());
    }

    private static IEnumerator SetupInitialOrientation()
    {
        if (PlayerPrefsUtils.HasOrientation())
        {
            if (PlayerPrefsUtils.IsPortrait())
            {
                SetupPortraitOrientation();
                if (Screen.orientation != ScreenOrientation.Portrait)
                {
                    Screen.orientation = ScreenOrientation.Portrait;
                    yield return new WaitForSeconds(3);
                    LoadScene();
                }
            }
            else
            {
                SetupLandscapeOrientation();
                if (Screen.orientation != ScreenOrientation.Landscape)
                {
                    Screen.orientation = ScreenOrientation.Landscape;
                    yield return new WaitForSeconds(3);
                    LoadScene();
                }
            }
            yield break;
        }

        if (Screen.orientation == ScreenOrientation.Portrait)
        {
            SetupPortraitOrientation();
        }
        else
        {
            SetupLandscapeOrientation();
        }

        LoadScene();
    }

    private static void LoadScene()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }

    private static void SetupPortraitOrientation()
    {
        Screen.autorotateToPortrait = true;
        Screen.autorotateToPortraitUpsideDown = true;
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;
    }

    private static void SetupLandscapeOrientation()
    {
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;
    }
}
