﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Manager : MonoBehaviour {

    public GameObject Enemy2;
    //    public float spawnTime = 5f;
    public Transform[] spawnPoints;
   // public Transform Enemy2;
//    public Enemy2Behavior enemy2;
//    public static int numEnemy2 = 0;
//    public static int maxEnemy2 = 0;


    // Use this for initialization
    void Start () {
 //       enemy2 = GetComponent<Enemy2Behavior>();
 //       InvokeRepeating("Spawn", 0.1f, spawnTime);
    }
	
    void Spawn ()
    {
        /*       int startingSpawnPosition = Random.Range(0, spawnPoints.Length);
               {
                   if (maxEnemy2 < 6)
                   {
                       Instantiate(Enemy2, spawnPoints[startingSpawnPosition].position, spawnPoints[startingSpawnPosition].rotation);
                       numEnemy2++;
                       maxEnemy2++;
                   }
                   UnityEngine.Debug.Log(numEnemy2);
             }
        */
        for (int i = 0; i < 5; i++)
        {
            Instantiate(Enemy2, new Vector2(Random.Range(-7.2f, 7.2f), Random.Range(-3f, 3f)), Quaternion.identity);

        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
