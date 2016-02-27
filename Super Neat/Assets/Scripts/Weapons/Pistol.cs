using UnityEngine;
using System.Collections;

public class Pistol : RangedWeapon {

	void Start () {
		this.ammo = 10;
	}

	void Update () {
	
	}

	override protected void Execute () {
		GameObject bullet = GameObject.Instantiate(bullet, this.transform.position, this.transform.rotation);
		bullet.GetComponent<Bullet> ();
	}

}
