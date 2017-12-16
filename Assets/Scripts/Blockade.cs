using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockade : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Projectile")
			Destroy (collision.gameObject);
		}
}
