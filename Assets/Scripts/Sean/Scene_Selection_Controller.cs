﻿// Sean Anderson
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Selection_Controller : MonoBehaviour
{
    // The user selects Level #1
    public void Game1()
    {
        // Go to the main game
        SceneManager.LoadScene("MainGame");
    }

    // The use selects Level #2
    public void Game2()
    {
        // Go to the main game
        SceneManager.LoadScene("MainGame2");
    }

    // The user selects Level #3
    public void Game3()
    {
        // Go to the main game
        SceneManager.LoadScene("MainGame3");
    }

    public void BackButton()
    {
        // Go to the last scene (GunSelection)
        SceneManager.LoadScene("GunSelection");
    }
}
