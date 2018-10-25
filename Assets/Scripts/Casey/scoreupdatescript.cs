﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scoreupdatescript : Interaction
{
  

    void OnGUI()
    {
        GUIStyle fontStyle = new GUIStyle(GUI.skin.GetStyle("label"));
        fontStyle.fontSize = 24;

        stringToEdit = GUI.TextField(new Rect(30, 20, 200, 50), "SCORE: " + score.ToString(), fontStyle);

        // Added by Sean Anderson, to quit the game and restart
        if(score==6)
        {
            Invoke("ExecuteAfterTime",1);
            SceneManager.LoadScene("Completed Menu");
            score = 0;
        }
    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(15);
    }

}