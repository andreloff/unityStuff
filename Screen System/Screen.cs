//Screen Management System
//Developed by Andre Cassio

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screen : MonoBehaviour
{
    public string screenName;
    //public AudioSource screenAudioSource;

    public virtual void SetScreen()
    {
        //Used to prepare screen elements, before show them to player 
    }

    public virtual void StartScreen()
    {
        //Used to start screen elements, like animations

        //screenAudioSource.Play();
    }

    public virtual void ChangeToNewScreen(Screen _newScreen)
    {
        _newScreen.SetScreen();
        ScreenManager.Instance.currentScreen.gameObject.transform.position = ScreenManager.Instance.cameraOutPos.transform.position;
        ScreenManager.Instance.currentScreen = _newScreen;
        ScreenManager.Instance.currentScreen.gameObject.transform.position = ScreenManager.Instance.cameraInPos.transform.position;
        _newScreen.StartScreen();
    }


}
