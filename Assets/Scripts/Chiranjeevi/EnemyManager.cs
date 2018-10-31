using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : Duck_Movement {

	public GameObject enemy;
	public float spawnTime = 5f;
	public Transform[] spawnPoints;
	public Duck_Movement duck;
	public static int noofDucks = 0;
	public static int maxDucks = 0;
	
	void Start()
	{
		duck = GetComponent<Duck_Movement>();
		Invoke("Spawn", 0.1f);        
	}

	// Update is called once per frame
	void Update () {
		if(duck.duck_Check() == true)
		{
			// duck.changeSound();
			Invoke("Spawn", 1);
			duck.setDuck(false);
		}	
		// UnityEngine.Debug.Log(noofDucks);
	}
	
	void Spawn()
	{	
		// duck.Initialize();
		int spawnPointIndex = Random.Range(0, spawnPoints.Length);
		UnityEngine.Debug.Log(spawnPointIndex);
		{
			if(maxDucks < 10)
			{
			Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
			noofDucks++;	
			maxDucks++;
			} 		
			// UnityEngine.Debug.Log(noofDucks);	
		}
		
	}

}
