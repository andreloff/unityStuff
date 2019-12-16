//Screen Management System
//Developed by Andre Cassio

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScreenManager : Singleton<ScreenManager>
{

    public Screen startScreen;

    public RectTransform cameraInPos;
    public RectTransform cameraOutPos;

    //Each individual screen should have its own Manager with singleton
    public Screen[] screens;

    [HideInInspector]
    public Screen currentScreen;

    private void Start()
    {
        startScreen = screens[0];

        currentScreen = startScreen;
        currentScreen.SetScreen();
        currentScreen.transform.position = cameraInPos.transform.position;
        currentScreen.StartScreen();
    }

    public void ChangeToScreen(string _screenName)
    {
        for(int i = 0; i < screens.Length; i++)
            if (screens[i].screenName == _screenName) currentScreen.ChangeToNewScreen(screens[i]);
    }
    public void ChangeToScreen(int _idx)
    {
        currentScreen.ChangeToNewScreen(screens[_idx]);
    }
}
