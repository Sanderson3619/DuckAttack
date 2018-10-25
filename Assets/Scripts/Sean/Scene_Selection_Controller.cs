// Sean Anderson
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Selection_Controller : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // Switch to 1600 x 1050 windowed
        Screen.SetResolution(1680, 1050, false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // The user selects Gun #1
    public void Game1()
    {
        // Go to the main game
        SceneManager.LoadScene("MainGame");
    }

    // The use selects Gun #2
    public void Game2()
    {
        // Go to the main game
        SceneManager.LoadScene("MainGame2");
    }

    // The user selects Gun #3
    public void Game3()
    {
        // Go to the main game
        SceneManager.LoadScene("MainGame3");
    }

    public void BackButton()
    {
        // Go to the help screen
        SceneManager.LoadScene("GunSelection");
    }
}
