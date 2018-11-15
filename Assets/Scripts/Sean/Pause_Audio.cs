using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Audio : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Game_BGMusic.Instance.gameObject.GetComponent<AudioSource>().Pause();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
