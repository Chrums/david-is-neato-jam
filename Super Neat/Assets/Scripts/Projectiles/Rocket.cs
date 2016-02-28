using UnityEngine;
using System.Collections;

public class Rocket : Projectile {

	[SerializeField]
	private GameObject explosion = null;

	void Start () {

	}

	override protected void Entered (Collider2D other) {
		Debug.Log ("Entered: " + other.tag);
		GameObject projectileInstance = GameObject.Instantiate (this.explosion, this.transform.position, this.transform.rotation) as GameObject;
		this.Destroy(this.gameObject);
	}
	
	override protected void Exited (Collider2D other) {
		Debug.Log ("Exited: " + other.tag);
	}
	
}
