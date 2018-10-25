using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreupdatescript : Interaction
{
    public Text timerText;
    private float currentTime = 0;
    private float step = 0.01f;
    Text timer;
    public string TimerString = " ";

    void Start()
    {
      
        timer = GetComponent<Text>();
        if (timer)
        {
            timer.text = "Time: 0";
          
        }
         
    }

    void OnGUI()
    {
        GUIStyle fontStyle = new GUIStyle(GUI.skin.GetStyle("label"));
        fontStyle.fontSize = 24;

        stringToEdit = GUI.TextField(new Rect(30, 20, 200, 50), "SCORE: " + score.ToString(), fontStyle);

        if (score == 6)
        {
            StartCoroutine(ExecuteAfterTime());
        }

        if (currentTime == 0)
        {
            StartCoroutine(ExecuteTimer());
        }

        TimerString = GUI.TextField(new Rect(600, 20, 200, 50), "Timer: " + (currentTime/2).ToString("n2"), fontStyle);
        
    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(3);

        //Abhilash is making this change below
        Cursor.visible = true;
       

        SceneManager.LoadScene("Completed Menu");

    }

    IEnumerator ExecuteTimer()
    {
        while (currentTime < 60)
        {
            yield return new WaitForSeconds(step);
            currentTime += step;
            
        }
        yield return new WaitForSeconds(step);
        Cursor.visible = true;
        SceneManager.LoadScene("Completed Menu");

    }

}