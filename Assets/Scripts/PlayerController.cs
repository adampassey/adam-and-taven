using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float MovementSpeed = 1.0f;
    public GameObject ProjectilePrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        //  if player is holding down W
        //  move up
        if (Input.GetKey(KeyCode.W)) {
            //  transform stores position, rotation, scale
            //  Vector3 is an object that has x, y, z
            //  Time.deltaTime is the difference betweeen frames
            transform.Translate(Vector2.up * MovementSpeed * Time.deltaTime);
        }

        //  move left
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector2.left * MovementSpeed * Time.deltaTime);
        }

        //  move down
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector2.down * MovementSpeed * Time.deltaTime);
        }

        //  move right
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector2.right * MovementSpeed * Time.deltaTime);
        }

        //  now let's calculate the angle of the mouse vs. the player's position
        //  get the current mouse position
        Vector2 mousePosition = Input.mousePosition;

        //  take the mouse position and convert it to world coordinates based
        //  on the main camera
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        //  draw a debug line just because
        Debug.DrawLine(transform.position, worldMousePosition, Color.red);

        //  fire if they click left mouse button
        if (Input.GetMouseButtonDown(0)) {

            //  spawn a projectile on the scene and set it to the players position
            GameObject projectile = Instantiate(ProjectilePrefab);
            projectile.transform.position = transform.position;

            //  get the direction the projectile fire
            Vector2 projectileDirection = worldMousePosition - transform.position;

            //  get access to projectile and set direction
            Projectile p = projectile.GetComponent<Projectile>();
            p.Direction = projectileDirection.normalized;
        }
    }
}

