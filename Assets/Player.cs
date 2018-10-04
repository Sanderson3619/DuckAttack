using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //public Texture2D cursorTexture;
    //public CursorMode cursorMode = CursorMode.Auto;
    //public Vector2 hotSpot = Vector2.zero;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //<<<<<<< HEAD
        /* Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(Camera.main.transform.position.z - transform.position.z)));
         newPos.z = transform.position.z;
         transform.position = newPos;
         */
    }
    //=======


    //>>>>>>> f5db390d258bf33ac12823dcf3218a0a67fbc508

    //on awake

    private void Awake()
    {
        //Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);

    }


    // Handle mouse click
    public void onShoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Mouse click");
            sendLocation();
        }
    }

    // Send location co-ordinates
    public Vector2 sendLocation()
    {
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);

        System.Console.WriteLine(mousePosition);
        Debug.Log(mousePosition);

        return mousePosition;
    }

    /*
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLIDE");
        Destroy(collision.gameObject);
        
    }
    */
}

