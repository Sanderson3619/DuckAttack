using System.Collections;
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

        if (score == 6)
        {
            StartCoroutine(ExecuteAfterTime());
        }

        
    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(3);

        //Abhilash is making this change below
        Cursor.visible = true;
        //------------------------------------

        SceneManager.LoadScene("Completed Menu");

    }

}