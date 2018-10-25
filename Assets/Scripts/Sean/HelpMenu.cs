﻿// Sean Anderson
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Switch to 1600 x 1050 windowed
        Screen.SetResolution(1680, 1050, false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void BackToMainMenu()
    {
        // Go to the help screen
        SceneManager.LoadScene("StartMenu");
    }

}
