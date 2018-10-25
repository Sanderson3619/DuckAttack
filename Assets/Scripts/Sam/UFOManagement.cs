using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOManagement : MonoBehaviour {

	public Transform ufo;
	private int count = 0;
	private int spawnTime = 4;

	// Use this for initialization
	void Start () {
		for(int i = 0; i < 100; i++){
			Instantiate (ufo, new Vector2(Random.Range(-7.2f,7.2f), Random.Range(-3f, 3f)), Quaternion.identity);
	
		}
	}

	// Update is called once per frame
	void Update () {
		/*
		count++;
		if (count == 30*spawnTime) {
			Instantiate (ufo, new Vector2(Random.Range(-7.2f,7.2f), Random.Range(-3f, 3f)), Quaternion.identity);
			count = 0;
		}
		*/
	}
}
