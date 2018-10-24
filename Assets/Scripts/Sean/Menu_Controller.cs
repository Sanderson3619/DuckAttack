// Sean Anderson
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // The user clicks the Start Game button
    public void StartGame ()
    {
        // Go to the main game
        SceneManager.LoadScene("GunSelection");

    }

    // The user clicks the Quit Game button
    public void QuitGame()
    {
        // Exit the unity.exe, does not work in the Unity Engine
        Application.Quit();
    }

    // The user clicks the Help button
    public void HelpScreen()
    {
        // Go to the help screen
        SceneManager.LoadScene("HelpMenu");
    }

    // The user clicks on the Sound Settings button
    public void SoundSettings()
    {
        // Go to the sound settings screen
        SceneManager.LoadScene("SoundMenu");
    }
}
