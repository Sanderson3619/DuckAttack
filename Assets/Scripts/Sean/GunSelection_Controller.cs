// Sean Anderson
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GunSelection_Controller : MonoBehaviour
{
    public int GunNumber;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // The user selects Gun #1
    public void Gun1Selected()
    {
        // Store that they chose Gun #1
        GunNumber = 1;
        // Go to the main game
        SceneManager.LoadScene("SceneSelection");
    }

    // The use selects Gun #2
    public void Gun2Selected()
    {
        // Store that they chose Gun #2
        GunNumber = 2;
        // Go to the main game
        SceneManager.LoadScene("SceneSelection");
    }

    // The user selects Gun #3
    public void Gun3Selected()
    {
        // Store that they chose Gun #3
        GunNumber = 3;
        // Go to the main game
        SceneManager.LoadScene("SceneSelection");
    }

    // The user selects Cheat
    public void CheaterCheaterPumpkinEater()
    {
        // Store that the user wants to be a cheater and use Gun #4
        GunNumber = 4;
        // Go to the main game
        SceneManager.LoadScene("SceneSelection");
    }
}
