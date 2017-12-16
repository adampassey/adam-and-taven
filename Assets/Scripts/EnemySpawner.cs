using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject EnemyPrefab;
    public float SpawnDelayInSeconds = 3.0f;

    private float lastSpawn;

	// Use this for initialization
	void Start () {
        lastSpawn = Time.timeSinceLevelLoad;
	}
	
	// Update is called once per frame
	void Update () { 
        //  spawn an enemy if the game ahs been loaded longer than
        //  the last spawn time + the spawn delay
        if (Time.timeSinceLevelLoad > lastSpawn + SpawnDelayInSeconds) {
            GameObject enemy = Instantiate(EnemyPrefab);

            //  randomize enemy position
            Vector2 randomPosition = new Vector2(Random.Range(-10f, 10f), Random.Range(-10f, 10f));
            enemy.transform.position = randomPosition;

            //  set the last spawn time
            //  should be set every time I spawn an enemy
            lastSpawn = Time.timeSinceLevelLoad;
        }
	}
}
