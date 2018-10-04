using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreupdatescript : Duck_Movement
{
    Text instruction;
    public static int score = 0;
    public string stringToEdit = "Hello World";

    // Use this for initialization
    void Start()
    {
        instruction = GetComponent<Text>();
        instruction.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (hit == true)
        {
            score = score + 1;

        }

    }

    void OnGUI()
    {
        GUIStyle fontStyle = new GUIStyle(GUI.skin.GetStyle("label"));
        fontStyle.fontSize = 24;

        stringToEdit = GUI.TextField(new Rect(30, 20, 200, 50), "SCORE: " + score.ToString(), fontStyle);

    }

}