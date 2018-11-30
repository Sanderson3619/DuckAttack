// Sean Anderson

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreens : scoreupdatescript
{

    void OnGUI()
    {
        GUIStyle fontStyle = new GUIStyle(GUI.skin.GetStyle("label"));
        fontStyle.fontSize = 32;
        fontStyle.normal.textColor = Color.black;

        stringToEdit = GUI.TextField(new Rect(250, 350, 2000, 50), "You had a score of " + score.ToString() + "! You needed 20 to win.", fontStyle);
    }
}