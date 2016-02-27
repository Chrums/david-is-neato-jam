using UnityEngine;
using System.Collections;

public class RangedWeapon : Weapon {
	
	[SerializeField]
	protected GameObject projectile = null;

	[SerializeField]
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

}
