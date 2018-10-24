﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck_Movement : EnemyManager
{

    public Vector2 position;
    public float positionX;
    public float positionY;
    public int score_Value = 0;
    public int duck_speed = 7;
    public bool hit = false;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("DuckMovement", 0.5f, 0.3f);
        
    }

    // Movement of the duck is declared here
    public void DuckMovement()
    {
        position = new Vector2(positionX,  positionY);

        int vectorX = (int)GetComponent<Rigidbody2D>().transform.position.x;
        int vectorY = (int)GetComponent<Rigidbody2D>().transform.position.y;


        if (vectorX <= -7.2)
        {
            positionX = 0.6F;
        }
        else if (vectorX >= 7.2)
        {
            positionX = -0.6F;
        }

        if (vectorY <= -3)
        {
            positionY = 1F;
        }
        else if (vectorY >= 3)
        {
            positionY = -1F;
        }

        // translate, not position!! To add position to previous position
        GetComponent<Rigidbody2D>().transform.Translate(position);
    }

//    public void Initialize()
// 	{	
//         UnityEngine.Debug.Log("noDucks");
//         int spawnPointIndex = Random.Range(0, spawnPoints.Length);
		
// 			if(maxDucks < 4)
// 			{
// 			Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
// 			noDucks++;	
// 			maxDucks++;
// 			UnityEngine.Debug.Log(noDucks);
// 			} 			
		
// 	}

    
    // Update is called once per frame
    void Update()
    {

    }

    // class Red_duck : Duck_Movement
    // {
    //     private int negetive_value = -5;

    // }

    // class Green_duck : Duck_Movement
    // {
    //     private int positive_value = +5;

    // }

}

    