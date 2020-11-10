using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    GameObject menu_Canvas;
    GameObject settings_Canvas;

    void Start()
    {
        menu_Canvas = GameObject.Find("MainMenu_Canvas");
        settings_Canvas = GameObject.Find("Settings_Canvas");

        settings_Canvas.SetActive(false);
        menu_Canvas.SetActive(true);
    }

    public void LoadLevel (int a)
    {
        Application.LoadLevel(a);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void LoadMenu ()
    {
        menu_Canvas.SetActive(true);
        settings_Canvas.SetActive(false);
    }

    public void LoadSettings()
    {
        menu_Canvas.SetActive(false);
        settings_Canvas.SetActive(true);
    }
}
