using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck_Movement : GunSelection_Controller
{

    public Vector2 position;
    public float positionX;
    public float positionY;
    public int score_Value = 0;
    public int duck_speed = 7;
    //SG
    public bool hit = false;



    // Use this for initialization
    void Start()
    {

        InvokeRepeating("DuckMovement", 0.5f, 0.2f);

    }

    // Movement of the duck is declared here
    public void DuckMovement()
    {
        position = new Vector2(1 * positionX, positionY);

        int vectorX = (int)GetComponent<Rigidbody2D>().transform.position.x;
        int vectorY = (int)GetComponent<Rigidbody2D>().transform.position.y;


        if (vectorX <= -7.5)
        {
            positionX = 0.6F;
        }
        else if (vectorX >= 7.5)
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
    // Update is called once per frame
    void Update()
    {

    }


    class Red_duck : Duck_Movement
    {
        private int negetive_value = -5;

    }

    class Green_duck : Duck_Movement
    {
        private int positive_value = +5;

    }

    //Added by Sam Gouru
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // stop all animations
            CancelInvoke();
            hit = true;
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
        }
    }

}