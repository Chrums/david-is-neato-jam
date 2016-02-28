using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shotgun : RangedWeapon {

	[SerializeField]
	private int scatter = 4;

	[SerializeField]
	private float variance = 0.0f;

	override protected List<Projectile> Fire (Vector3 direction) {
		List<Projectile> projectiles = new List<Projectile> ();
		for (int i = 0; i < this.scatter; i++) {
			float x = Random.value - 0.5f * this.variance;
			float y = Random.value - 0.5f * this.variance;
			Vector3 modified = new Vector3 (direction.x + x, direction.y + y, direction.z).normalized;
			projectiles.Add (this.CreateProjectile (modified));
		}
		return projectiles;
	}

	override protected void Fired (List<Projectile> projectiles) {
		
	}
	
}
