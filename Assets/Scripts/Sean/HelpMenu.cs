﻿// Sean Anderson
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpMenu : MonoBehaviour {

    public void BackToMainMenu()
    {
        // Go to the help screen
        SceneManager.LoadScene("StartMenu");
    }

}
