// Sean Anderson
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {

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
