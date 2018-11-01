using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : Duck_Movement {

	// Prefab of the enemy, we use this in instantiate method to spawn the enemy.
	public GameObject enemy;
	// Float variable declared to wait until the time to spawn the next ducks.
	public float spawnTime = 5f;
	// These are the points where the ducks spawn in unity engine. 
	public Transform[] spawnPoints;
	// This is the variable that acts as the Duck_Movement script. 
	public Duck_Movement duck;
	// Variable to check the number of ducks spawned.
	public static int noOfDucks = 0;
	// Variable to check the maximum number of ducks spawned.
	public static int maxDucks = 0;
	
	void Start()
	{
		// This calls the Duck_Movement script to the variable duck.
		duck = GetComponent<Duck_Movement>();
		// Invokes the spawn method after 0.1f second.
		Invoke("spawn", 0.1f);        
	}

	// Update is called once per frame
	void Update () {
		// Checks if the duck is dead or alive by calling the duckCheck method in the Duck_Movement script.
		if(duck.duckCheck() == true)
		{
			// Invokes the spawn method after 0.1f second.
			Invoke("spawn", 0.1f);
			// Sets backs the duck status as alive after spawning the new enemy.
			duck.setDuck(false);
		}	
	}
	
	// This method spawns the enemy from the spawn points declared in unity.
	void spawn()
	{	
		// Uses this variable and calls the random function to spawn the enemies at random positions.
		int spawnPointIndex = Random.Range(0, spawnPoints.Length);
		{
			// Make sure to spawn less than 10 ducks startinf from 0. 
			if(maxDucks < 10)
			{
			// Instantiate the enemy with the prefab attached to it.
			Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
			// Increments the number of ducks after spawned.
			noOfDucks++;	
			// Increments the maximum number of ducks after spawned.
			maxDucks++;
			} 			
		}
		
	}

}
