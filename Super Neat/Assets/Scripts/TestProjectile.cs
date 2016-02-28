using UnityEngine;
using System.Collections;

public class TestProjectile : MonoBehaviour {
	
	public float speed;
	public Vector3 direction;

	void Update () {

		transform.position += direction * speed * Time.deltaTime;	
	}

	void OnCollisionEnter2D(Collision2D collider) {

        Destroy(gameObject);
	}
}