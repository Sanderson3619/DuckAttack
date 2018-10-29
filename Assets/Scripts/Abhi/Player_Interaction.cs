using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Interaction : GunSelection_Controller
{

    AudioSource gunSound;
    GunSelection_Controller test;
    public Sprite mySprite1;
    public Sprite mySprite2;
    public Sprite mySprite3;
    private SpriteRenderer spriteRenderer;
    private int gun = 1;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Begin");
        gunSound = GetComponent<AudioSource>();
        test = GetComponent<GunSelection_Controller>();
        this.gun = test.getGunNumber();
        spriteRenderer = GetComponent<SpriteRenderer>();
        Cursor.visible = false;

        //Test gun selection
        Debug.Log("Gun: " + this.gun);

        if (this.gun == 1)
        {
            spriteRenderer.sprite = mySprite1;
        } else if(this.gun == 2)
        {
            spriteRenderer.sprite = mySprite2;
        }
        else
        {
            spriteRenderer.sprite = mySprite3;
        } 

        /*
        Vector2 point = new Vector2();
        point = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        Debug.Log("World: " + point.ToString());*/

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(Camera.main.transform.position.z - transform.position.z)));
        newPos.z = transform.position.z;
        transform.position = newPos;

        //Testing mouse position to scope position
        //Debug.Log(newPos);
        if (Input.GetMouseButtonDown(0) == true)
        {
            gunSound.Play();
            this.spriteRenderer.transform.localScale += new Vector3(0.02f, 0.02f, 0f);
            //Should figure out a way to put some delay here
            //The delay should merely pass time by doing something else, but not pause the processing
            this.spriteRenderer.transform.localScale -= new Vector3(0.02f, 0.02f, 0f);

        }
    }

}
