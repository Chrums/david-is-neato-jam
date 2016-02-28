using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RangedWeapon : Weapon {
	
	[SerializeField]
	protected GameObject projectile = null;

	[SerializeField]
	private Transform projectileOrigin = null;

	[SerializeField]
	protected int ammo = 0;

	protected GameObject CreateProjectile (Vector3 direction) {
		return GameObject.Instantiate (this.projectile, projectileOrigin.position, Quaternion.FromToRotation(Vector3.right, direction)) as GameObject;
	}

	override public void Execute (Vector3 direction) {
		if (this.ammo > 0) {
			ammo--;
			List<GameObject> projectiles = Fire (direction);
			Fired (projectiles);
		}
	}

	virtual protected List<GameObject> Fire (Vector3 direction) {
		List<GameObject> projectiles = new List<GameObject> ();
		projectiles.Add (this.CreateProjectile (direction));
		return projectiles;
	}

	virtual protected void Fired (List<GameObject> projectiles) { }

}
