using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour {

    public GameObject Target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (Target == null) {
            return;
        }

        Vector3 newPosition = Target.transform.position;
        newPosition.z = transform.position.z;
        transform.position = newPosition;
	}
}
