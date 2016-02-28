using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	private const string CHARACTER_TAG = "Character";

	protected float speed = 0.0f;
	private CircleCollider2D collider;

	void Start () {
		this.collider = this.gameObject.GetComponent<CircleCollider2D> ();
	}

	void Update () {
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag (CHARACTER_TAG)) this.EnteredCharacter (other);
		else this.EnteredOther (other);
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.CompareTag (CHARACTER_TAG)) this.ExitedCharacter (other);
		else this.ExitedOther (other);
	}

	virtual protected void EnteredCharacter (Collider2D other) { }
	virtual protected void ExitedCharacter (Collider2D other) { }
	
	virtual protected void EnteredOther (Collider2D other) { }
	virtual protected void ExitedOther (Collider2D other) { }

}
