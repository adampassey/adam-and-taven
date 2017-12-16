using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour {

    public int MaxLife = 10;
    public bool DisplayHealth = false;

    private int currentLife;

	// Use this for initialization
	void Start () {
        currentLife = MaxLife;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnGUI() {
        //  "Health: 4 / 10"
        GUI.Label(new Rect(10, 10, 100, 100), "Health: " + currentLife + " / " + MaxLife);
    }

    public void TakeDamage(int damage) {
        currentLife = currentLife - damage;

        //  this is the same line as above but "shorthand"
        //  currentLife -= damage;

        if (currentLife <= 0) {
            Die();
        }
    }

    public void Die() {
        Destroy(gameObject);
    }
}
