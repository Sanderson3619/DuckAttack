using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{

    public int scoreValue = 0;
    public int duck_speed = 10;
    public int requiredScore = 10;
    public int positionX = -1;
    public int positionY = -1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LevelUp()
    {
        SceneManager.LoadScene("MainGame");
        InvokeRepeating("duckMovement", 0.5f, 0.2f);
        duck_speed = 20;

    }

    public void Replay()
    {
        SceneManager.LoadScene("MainGame");

    }

    void LevelDecider()
    {
        // if scoreValue is more than or equal to required score
        // then checkScore is set to 1 or true
        // if checkScore is true then proceed to next level

        // if scoreValue is less than required score
        // then checkScore is set to 0 or false
        // if check score is false then replay level
        if (scoreValue >= requiredScore)
        {
            LevelUp();
        }
        else
            Replay();
    }

}