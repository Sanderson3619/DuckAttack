using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
/*
private static var instance:MyUnitySingleton;
public static function GetInstance() : MyUnitySingleton {
return instance;
}


function Awake()
{
    if (instance != null && instance != this)
    {
        Destroy(this.gameObject);
        return;
    }
    else
    {
        instance = this;
    }
    DontDestroyOnLoad(this.gameObject);
}
https://answers.unity.com/questions/11314/audio-or-music-to-continue-playing-between-scene-c.html

    */