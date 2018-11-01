using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOManagement : MonoBehaviour {

	public Transform ufo;
	//include the prefab for an enmey so it can spawn them
	private int count = 0;
	//counts frames since last reset
	private int spawnTime = 4;
	//time in seconds between each enemy spawn
	public int testCaseSpawns = 1;
	//used for stress test, how many enemies spawn at beginning

	// Use this for initialization
	void Start () {
		for(int i = 0; i < testCaseSpawns; i++){
			Instantiate (ufo, new Vector2(Random.Range(-7.2f,7.2f), Random.Range(-3f, 3f)), Quaternion.identity);
	
		}
	}

	// Update is called once per frame
	void Update () {
		count++;
		if (count == 30*spawnTime) {
			Instantiate (ufo, new Vector2(Random.Range(-7.2f,7.2f), Random.Range(-3f, 3f)), Quaternion.identity);
			count = 0;
		}
	}
}
