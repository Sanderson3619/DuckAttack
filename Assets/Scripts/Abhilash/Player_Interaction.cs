using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Interaction : GunSelection_Controller
{

    AudioSource m_GunSound;
    // Stores the audio for the gun shot.
    GunSelection_Controller m_Test;
    // Instance of the class gun selection.
    public Sprite m_MySprite1;
    public Sprite m_MySprite2;
    public Sprite m_MySprite3;
    // Holds the three different gun png's.
    private SpriteRenderer m_SpriteRenderer;
    // Holds the required gun png sprite.
    private int m_Gun = 1;
    // Choice of gun.

    // Use this for initialization.
    void Start()
    {
        Debug.Log("Begin");
        m_GunSound = GetComponent<AudioSource>();
        m_Test = GetComponent<GunSelection_Controller>();
        this.m_Gun = m_Test.m_GetGunNumber();
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        Cursor.visible = false;

        // Test gun selection.
        Debug.Log("Gun: " + this.m_Gun);

        if (this.m_Gun == 1)
        {
            m_SpriteRenderer.sprite = m_MySprite1;
        } else if(this.m_Gun == 2)
        {
            m_SpriteRenderer.sprite = m_MySprite2;
        }
        else
        {
            m_SpriteRenderer.sprite = m_MySprite3;
        } 

        /*
        Vector2 point = new Vector2();
        point = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        Debug.Log("World: " + point.ToString());*/
        // The commented code is for Chiru's reference.

    }

    // Update is called once per frame.
    void Update()
    {
        Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(Camera.main.transform.position.z - transform.position.z)));
        newPos.z = transform.position.z;
        transform.position = newPos;

        // Testing mouse position to scope position.
        // Debug.Log(newPos);
        if (Input.GetMouseButtonDown(0) == true)
        {
            m_GunSound.Play();
            this.m_SpriteRenderer.transform.localScale += new Vector3(0.02f, 0.02f, 0f);
            // Should figure out a way to put some delay here.
            // The delay should merely pass time by doing something else, but not pause the processing.
            this.m_SpriteRenderer.transform.localScale -= new Vector3(0.02f, 0.02f, 0f);

        }
    }

}
