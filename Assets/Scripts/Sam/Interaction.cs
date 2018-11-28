using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : Duck_Movement
{
    Text instruction;
    public static int score = 0;
    public string stringToEdit = " ";
    private Duck_Movement duckScore;

    // Use this for initialization
    void Start () {
        instruction = GetComponent<Text>();
        duckScore = GetComponent<Duck_Movement>();
        if (instruction)
        {
            instruction.text = "Score: 0";
        }
        
    }

    void Update_score(bool hit)
    {
        if (hit == true)
        {
            score = score + duckScore.scoreValue;
            Duck_Movement.isDead = true;
        }
        
    }
    
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // stop all animations
            CancelInvoke();
            InvokeRepeating("DuckHit", 0.5f, 0.1f);

        }

    }


    void DuckHit()
    {       
        position = new Vector2(0, -1);
        int ips = (int)GetComponent<Rigidbody2D>().transform.position.y;

        GetComponent<Rigidbody2D>().transform.Translate(position);

        if (ips <= -3)
        {
            gameObject.SetActive(false);
            CancelInvoke();
            hit = true;
        }

        Update_score(hit);
    }


}


