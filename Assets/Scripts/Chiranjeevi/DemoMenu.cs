using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DemoMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MenuTest ()
    {
		SceneManager.LoadScene("StartMenu");
    }

	public void PlayerTest ()
    {
        // Go to the main game
        SceneManager.LoadScene("MainGamePlayerTest");

    }

	public void EnemyTest ()
    {
        // Go to the main game
        SceneManager.LoadScene("MainGameEnemyTest");

    }

	public void ScoreTest ()
    {
        // Go to the main game
        SceneManager.LoadScene("MainGamePlayerTest");

    }
	public void BackToMainMenu()
    {
        // Go back to the Start Menu
        SceneManager.LoadScene("StartMenu");
    }
}
