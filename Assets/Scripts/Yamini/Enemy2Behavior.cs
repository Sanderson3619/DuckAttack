using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy2Behavior : Enemy2Manager {

    public Vector2 position;
    private float positionX;
    private float positionY;

    // Use this for initialization
    void Start () {
        InvokeRepeating("Enemy2Movement", 0.5f, 0.3f);
    }

    // Enemy2Behavior
    public void Enemy2Movement()
    {
        position = new Vector2(positionX, positionY);

        int vectorX = (int)GetComponent<Rigidbody2D>().transform.position.x;
        int vectorY = (int)GetComponent<Rigidbody2D>().transform.position.y;


        if (vectorX <= -7.2)
        {
            positionX = 0.3F;
        }
        else if (vectorX >= 7.2)
        {
            positionX = -0.3F;
        }

        if (vectorY <= -3)
        {
            positionY = 0.2F;
        }
        else if (vectorY >= -1)
        {
            positionY = -0.2F;
        }

        // translate, not position!! To add position to previous position
        GetComponent<Rigidbody2D>().transform.Translate(position);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
