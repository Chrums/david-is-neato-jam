using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RangedWeapon : Weapon {
	
	[SerializeField]
	protected Projectile projectile = null;

	[SerializeField]
	private Transform projectileOrigin = null;

	[SerializeField]
	protected int ammo = 0;

	protected Projectile CreateProjectile (Vector3 direction) {
		Projectile proj = GameObject.Instantiate (this.projectile, projectileOrigin.position, Quaternion.FromToRotation(Vector3.right, direction)) as Projectile;
		if(proj != null) {
			proj.WeaponId = weaponId;
		}
		return proj;
	}

	override public void Execute (Vector3 direction) {
		if (this.ammo > 0) {
			ammo--;
			List<Projectile> projectiles = Fire (direction);
			Fired (projectiles);
		}
	}

	virtual protected List<Projectile> Fire (Vector3 direction) {
		List<Projectile> projectiles = new List<Projectile> ();
		projectiles.Add (this.CreateProjectile (direction));
		return projectiles;
	}

	virtual protected void Fired (List<Projectile> projectiles) { }

}
