using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        onShoot();
	}

    //on awake

    private void Awake()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    // Handle mouse click
    void onShoot()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            sendLocation();
        }
    }

    // Send location co-ordinates
    Vector2 sendLocation()
    {
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);

        System.Console.WriteLine(mousePosition);
        Debug.Log(mousePosition);

        return mousePosition;
    }
}
