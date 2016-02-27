using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public TestProjectile testProjectilePrefab;
	public float moveSpeed;
	public float maxRotateAmount = 90.0f;

	public Transform legs;
	public Transform torso;
	public Transform bulletSpawnOrigin;

	public void Move(Vector3 movement) {

		Vector3 previousPosition = transform.position;
		transform.position += movement * moveSpeed * Time.deltaTime;

//		Debug.Log(Vector3.Angle(legs.right, torso.right));

		if(Vector3.Distance(transform.position, previousPosition) > 0.01f) {
			legs.right = movement.normalized;
		}

		Debug.DrawRay(legs.position, legs.right, Color.blue);
	}

	public void Aim(Vector3 position) {
		
		Vector3 direction = (position - transform.position).normalized;
		
		if(Vector3.Angle(direction, legs.right) < maxRotateAmount) {
			torso.right = direction;
		} else {
			legs.right = direction;
		}

		Debug.DrawRay(legs.position, torso.right, Color.red);
	}
	
	public void Shoot(Vector3 position) {

		TestProjectile projectile = GameObject.Instantiate<TestProjectile>(testProjectilePrefab);
		projectile.transform.position = bulletSpawnOrigin.position;
		projectile.speed = 4.0f;
		projectile.direction = (position - transform.position).normalized;
	}

	void OnCollisionEnter2D(Collision2D collider) {

        if(collider.gameObject.tag == "Projectile") {
        	Debug.Log("Dead");
		}
	}
}