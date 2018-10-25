using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

	public GameObject enemy;
	public float spawnTime = 5f;
	public Transform[] spawnPoints;
	public Duck_Movement duck;
	public static int noofDucks = 0;
	public static int maxDucks = 0;
	
	void Start()
	{
		duck = GetComponent<Duck_Movement>();
		InvokeRepeating("Spawn", 0.1f, spawnTime);
		        
	}

	// Update is called once per frame
	void Update () {
		// if(duck.isDead == true)
		// {
		// 	Invoke("Spawn", 1);
		// 	duck.isDead = false;
		// }	
		// UnityEngine.Debug.Log(noofDucks);
	}
	
	void Spawn()
	{	
		// duck.Initialize();
		int spawnPointIndex = Random.Range(0, spawnPoints.Length);
		{
			if(maxDucks < 6)
			{
			Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
			noofDucks++;	
			maxDucks++;
			} 		
			UnityEngine.Debug.Log(noofDucks);	
		}
		
	}

}
