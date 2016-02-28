using UnityEngine;
using System.Collections;

public class Bullet : Projectile {

	override protected void Entered (Collider2D other) {
		Debug.Log ("Entered: " + other.tag);
	}

	override protected void Exited (Collider2D other) {
		Debug.Log ("Exited: " + other.tag);
	}

}
