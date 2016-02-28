using UnityEngine;
using System.Collections;
<<<<<<< HEAD
=======
using System.Collections.Generic;
>>>>>>> master

public class RangedWeapon : Weapon {
	
	[SerializeField]
	protected GameObject projectile = null;

	[SerializeField]
<<<<<<< HEAD
	protected int ammo = 0;

	void Start () {
	
	}

	void Update () {
	
	}

	override public void Use () {
		if (this.ammo > 0) {
			Fired ((GameObject) GameObject.Instantiate(this.projectile, this.transform.position, this.transform.rotation));
		}
	}

	virtual protected void Fired (GameObject projectile) { }
=======
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
>>>>>>> master

}
