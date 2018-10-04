using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreupdatescript : MonoBehaviour {

	Text instruction;
	private int score = 0;

	// Use this for initialization
	void Start () {
		instruction = GetComponent<Text> ();
		instruction.text = "Score: 0";
	}

	// Update is called once per frame
	void Update () {
		instruction.text = "Score: " + score;
	}
}
