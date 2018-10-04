using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck_Movement : GunSelection_Controller {

    public Vector2 position;
    public int positionX = -1;
    public int positionY = -1;
    public int score_Value = 0;
    public int duck_speed = 10;

    // Use this for initialization
    void Start () {
                
        InvokeRepeating("duckMovement", 0.5f, 0.2f);

    }

    // Movement of the duck is declared here
    void duckMovement()
    {
        position = new Vector2(1 * positionX, positionY);

        int vectorX = (int)GetComponent<Rigidbody2D>().transform.position.x;
        int vectorY = (int)GetComponent<Rigidbody2D>().transform.position.y;

        
        if (vectorX <= -7.5)
        {
            positionX = 1;
        }
        else if (vectorX >= 7.5)
        {
            positionX = -1;
        }
        if (vectorY <= -3)
        {
            positionY = 1;
        }
        else if (vectorY >= 3)
        {
            positionY = -1;
        }

        // translate, not position!! To add position to previous position
        GetComponent<Rigidbody2D>().transform.Translate(position);

    }
    // Update is called once per frame
    void Update () {
		
	}

    class Red_duck : Duck_Movement
    {
        private int negetive_value = -5;

    }

    class Green_duck : Duck_Movement
    {
        private int positive_value = +5;

    }
}
