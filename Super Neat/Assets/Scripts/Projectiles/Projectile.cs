using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

<<<<<<< HEAD
	private const string CHARACTER_TAG = "Character";

	protected float speed = 0.0f;
=======
	[SerializeField]
	protected float speed = 0.0f;

>>>>>>> master
	private CircleCollider2D collider;

	void Start () {
		this.collider = this.gameObject.GetComponent<CircleCollider2D> ();
	}

	void Update () {
<<<<<<< HEAD
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
=======
		this.transform.Translate (Vector3.right * speed, this.transform);
	}

	void OnTriggerEnter2D (Collider2D other) {
		this.Entered (other);
	}

	void OnTriggerExit2D (Collider2D other) {
		this.Exited (other);
	}
	
	virtual protected void Entered (Collider2D other) { }
	virtual protected void Exited (Collider2D other) { }
>>>>>>> master

}
