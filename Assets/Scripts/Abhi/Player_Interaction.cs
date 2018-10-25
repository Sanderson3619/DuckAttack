using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Interaction : Player
{

    AudioSource gunSound;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Begin");
        gunSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(Camera.main.transform.position.z - transform.position.z)));
        newPos.z = transform.position.z;
        transform.position = newPos;

        if (Input.GetMouseButtonDown(0) == true)
        {
            gunSound.Play();
        }
    }

}
