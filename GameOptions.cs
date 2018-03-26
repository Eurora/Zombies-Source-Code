using UnityEngine;
using UnityEngine.UI;

public static class GameOptions
{
    public static bool Showing = false;
    private static GameObject OptionsPanel = new GameObject();

    public static void Show()
    {
        Showing = true;
        OptionsPanel.SetActive(true);
    }
    
    public static void Hide()
    {
        Showing = false;
        OptionsPanel.SetActive(false);
    }
    
    public static void ShowFPS(ushort FPS)
    {

    }
}