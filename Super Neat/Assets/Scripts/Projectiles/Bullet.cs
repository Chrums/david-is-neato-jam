using UnityEngine;
using System.Collections;

public class Bullet : Projectile {

	void Start () {
		this.speed = 10.0f;
	}

	void Update () {
	
	}

	override protected void EnteredCharacter (Collider2D other) {
		Debug.Log ("Entered: " + other.tag);
	}

	override protected void ExitedCharacter (Collider2D other) {
		Debug.Log ("Exited: " + other.tag);
	}

}
