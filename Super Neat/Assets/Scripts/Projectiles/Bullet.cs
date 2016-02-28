using UnityEngine;
using System.Collections;

public class Bullet : Projectile {

	override protected void Entered (Collider2D other) {
		Character character = other.GetComponent<Character>();
		if(character != null) {
			character.Kill();
			Destroy(gameObject);
		}

		Projectile projectile = other.GetComponent<Projectile>();
		if(projectile != null && weaponId != projectile.WeaponId) { 
			Destroy(gameObject);
		}
	}

	override protected void Exited (Collider2D other) {
		Debug.Log ("Exited: " + other.tag);
	}

}
