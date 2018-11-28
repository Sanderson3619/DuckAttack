using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special_Enemy_Manager : MonoBehaviour {

// Prefab of the enemy, we use this in instantiate method to spawn the enemy.
	public GameObject enemy;
	// These are the points where the ducks spawn in unity engine. 
	public Transform[] SpecialspawnPoints;
	public float Spawntime = 8f;
	public static int SpecialDucks = 0;
	
	void Start()
	{
		InvokeRepeating("SpecialDuckspawn", Spawntime, 15f);	
	}
	
	// This method spawns the enemy from the spawn points declared in unity.
	void SpecialDuckspawn()
	{	
		// Uses this variable and calls the random function to spawn the enemies at random positions.
		int spawnPointIndex = Random.Range(0, SpecialspawnPoints.Length);
		{
			if(SpecialDucks < 5)
			{
				// Instantiate the enemy with the prefab attached to it.
				Instantiate(enemy, SpecialspawnPoints[spawnPointIndex].position, SpecialspawnPoints[spawnPointIndex].rotation);
				SpecialDucks++;		
			}	
		}
		
	}
}
