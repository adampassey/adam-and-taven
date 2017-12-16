using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    //  speed of bullet
    public float Speed = 1.0f;

    //  doesn't have depth, only left and right
    public Vector2 Direction = Vector2.up;

    //  lifetime of bullet
    public float Lifetime = 3f;

    //  when the projectile is born
    private float bornAt;

	// Use this for initialization
	void Start () {
        bornAt = Time.timeSinceLevelLoad;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Direction * Speed * Time.deltaTime);

        //  if I'm too old, kill me
        if (Time.timeSinceLevelLoad > bornAt + Lifetime) {
            Destroy(gameObject);
        }
	}

    //  Projectile p = new Projectile();
    //  p.IncreaseDamage();
    public void IncreaseDamage() {

    }

    //  Projectile p = new Project();
    //  p.increaseDamage(); <- throw an error
    private void increaseDamage() {

    }

    public float GetSpeed() {
        return Speed;
    }

    //  called when the projectile collides with a collider
    //  in this case: enemy
    public void OnCollisionEnter2D(Collision2D collision) {
        //  if we collided with the player, stop executing
        if (collision.gameObject.name == "Player")  {

            //  this will exit the function
            //  so nothing below will get called
            return;
        }

        //  if this is an enemy, destroy the enemy
        //  and increase score
        if (collision.gameObject.tag == "Enemy") {
            Destroy(collision.gameObject);

            Player.Score = Player.Score + 10;
        }

		//Destroy me (the projectile)
		Destroy (gameObject);	
   }
}
