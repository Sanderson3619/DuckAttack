using UnityEngine;

public class EnemyManager : Duck_Movement {

	// Prefab of the enemy, we use this in instantiate method to spawn the enemy.
	public GameObject m_Enemy;
	// These are the points where the ducks spawn in unity engine. 
	public Transform[] m_SpawnPoints;
	// This is the variable that acts as the Duck_Movement script. 
	public Duck_Movement m_duck;
	// Variable to check the number of ducks spawned.
	public static int s_NoOfDucks = 0;
	// Variable to check the maximum number of ducks spawned.
	public static int s_MaxDucks = 0;
	public static bool m_DuckDead;
	void Start()
	{
		// This calls the Duck_Movement script to the variable duck.
		m_duck = GetComponent<Duck_Movement>();
		// Invokes the spawn method after 0.1f second.
		Invoke("spawn", 0.1f);
		//InvokeRepeating("RedduckSpawn", 5f, 5f);
		//InvokeRepeating("GreenduckSpawn", 3f, 4f);	
	}

	// Update is called once per frame
	void Update () {
		// Checks if the duck is dead or alive by calling the duckCheck method in the Duck_Movement script.
		if(m_duck.duckCheck() == true)
		{
			// Invokes the spawn method after 0.1f second.
			Invoke("spawn", 0.1f);
			// Sets backs the duck status as alive after spawning the new enemy.
			m_duck.setDuck(false);
			s_NoOfDucks--;
		}	
	}
	
	// This method spawns the enemy from the spawn points declared in unity.
	void spawn()
	{	
		// Uses this variable and calls the random function to spawn the enemies at random positions.
		int spawnPointIndex = Random.Range(0, m_SpawnPoints.Length);
		{
			// Make sure to spawn less than 10 ducks starting from 0. 
			if(s_MaxDucks < 15  && s_NoOfDucks <= 2)
			{
				// Instantiate the enemy with the prefab attached to it.
				Instantiate(m_Enemy, m_SpawnPoints[spawnPointIndex].position, m_SpawnPoints[spawnPointIndex].rotation);
				// Duck_ducksMovement.spawnTime = 0;
				// Increments the number of ducks after spawned.
				s_NoOfDucks++;
				// Increments the maximum number of ducks after spawned.
				s_MaxDucks++;
			} 			
		}
	}
	
	public int duckCount()
	{
		return s_NoOfDucks;
	}

	public void setDuckCount(int m_ducks)
	{
		s_NoOfDucks = m_ducks;
	}

	// void nextSpawn()
	// {
	// 	Duck_Movement.spawnTime += 1;
	// 	if((Duck_Movement.spawnTime/4) >= 20f)
	// 	{
	// 		Duck_Movement.spawnTime = 0f;
	// 	}
	// 	UnityEngine.Debug.Log("Time : " + Duck_Movement.spawnTime/4);
	// }

}
