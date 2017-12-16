using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float MovementSpeed = 0.01f;
    private GameObject player;

	// Use this for initialization
	void Start () {
        //  find the player in the scene
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        //  determine the direction I should move based on player position
        //  target position - current position = direction
        Vector2 direction = player.transform.position - transform.position;

        //  "normalizing" a vector3 removes distance and should be 
        //  used to determine direction not difference in location
        transform.Translate(direction.normalized * MovementSpeed * Time.deltaTime);
	}

}


