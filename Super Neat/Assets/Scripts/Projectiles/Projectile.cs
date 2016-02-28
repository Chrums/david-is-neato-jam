using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	[SerializeField]
	protected float speed = 0.0f;

	protected int weaponId;
	public int WeaponId {
		get { return weaponId; } 
		set { weaponId = value; }
	}

	private CircleCollider2D collider;

	void Start () {
		this.collider = this.gameObject.GetComponent<CircleCollider2D> ();
	}

	void Update () {
		
		this.transform.Translate (Vector3.right * speed * Time.deltaTime, this.transform);
	}

	void OnTriggerEnter2D (Collider2D other) {
		this.Entered (other);
	}

	void OnTriggerExit2D (Collider2D other) {
		this.Exited (other);
	}
	
	virtual protected void Entered (Collider2D other) { }
	virtual protected void Exited (Collider2D other) { }

}
