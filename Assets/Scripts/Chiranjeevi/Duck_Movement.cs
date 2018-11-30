﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck_Movement : MonoBehaviour
{
    // Two dimensional vector variable to store the position of the enemy. 
    public Vector2 m_Position;
    // Float variable declared to chnage the direction of the ducks when they reached the boundaries. 
    private float m_PositionX = -1;
    // Float variable declared to chnage the direction of the ducks when they reached the boundaries.
    private float m_PositionY= 1;
    // Integer variabe declared to update the score value each time they shot by the user. 
    public int m_ScoreValue = 1;
    // Bool variable declared to check whether the enemy is hit or not.
    public bool m_Hit = false;
    // Static bool variable declared to check whether the duck is dead or alive. 
    public static bool s_IsDead = false;
    // Float variable declared to wait until the time to spawn the next ducks.
	// public static float spawnTime = 0;

    // Use this for initialization
    void Start()
    {
        // Invokes DuckMovement repeatedly until the duck is dead or shot.
        InvokeRepeating("duckMovement", 0.5f, 0.3f);
    }

    // Movement of the duck is declared here.
    public void duckMovement()
    {
        // Variable declared to get the current position of the duck. 
        m_Position = new Vector2(m_PositionX,  m_PositionY);

        // Integer variable declared to get the X position of the enemy. 
        int m_vectorX = (int)GetComponent<Rigidbody2D>().transform.position.x;
        // Integer variable declared to get the Y position of the enemy. 
        int m_vectorY = (int)GetComponent<Rigidbody2D>().transform.position.y;

        // Boundaries of the duck to move between the screen.
        if (m_vectorX <= -7.2)
        {
            m_PositionX = 0.6F;
        }
        else if (m_vectorX >= 7.2)
        {
            m_PositionX = -0.6F;
        }

        if (m_vectorY <= -3)
        {
            m_PositionY = 1F;
        }
        else if (m_vectorY >= 3)
        {
            m_PositionY = -1F;
        }
        // Translate, not position!! To add position to previous position.
        GetComponent<Rigidbody2D>().transform.Translate(m_Position);
    }

    // Returns the status of the duck i.1 dead or alive.
    public virtual bool duckCheck()
    {
        return s_IsDead;
    }

    // Sets back the state of the duck to its value passed.
    public void setDuck(bool m_Value)
    {
        s_IsDead = m_Value;
    }

}

    