using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static int Score = 0;

    private Actor actor;

	// Use this for initialization
	void Start () {
        actor = GetComponent<Actor>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnGUI() {
        GUI.Label(new Rect(10, 40, 100, 100), "Score: " + Score);
    }

    public void OnCollisionEnter2D(Collision2D collision) {
        /*
        Enemy e = collision.gameObject.GetComponent<Enemy>();
        actor.TakeDamage(e.damage);
        */
        if (collision.gameObject.tag == "Enemy") {
            actor.TakeDamage(1);
        }
    }
}
