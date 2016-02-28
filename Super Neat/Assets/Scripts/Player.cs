using UnityEngine;
using System.Collections;

public class Player : Character {

	public SpriteRenderer gunSprite;

	public Transform bulletCenter;
	public Transform bulletSpawnOrigin;

	public void Move(Vector3 movement) {

		Vector3 previousPosition = transform.position;
		transform.position += movement * moveSpeed * Time.deltaTime;
	}

	public void Aim(Vector3 position) {
		
		Vector3 direction = (position - transform.position).normalized;

		gunSprite.sortingOrder = Vector3.Dot(direction, transform.up) > 0.0f ? 0 : 2;

		if(Vector3.Angle(transform.right, direction) > 90.0) {
			transform.right = -transform.right;
		}
		
		bulletCenter.right = direction;
	}
	
	public void Shoot(Vector3 position) {

		if(weapon != null) {
//			weapon.Use((position - transform.position).normalized);
			Debug.DrawRay(bulletSpawnOrigin.position, (position - transform.position).normalized, Color.red, 0.5f);
		}

//		TestProjectile projectile = GameObject.Instantiate<TestProjectile>(testProjectilePrefab);
//		projectile.transform.position = bulletSpawnOrigin.position;
//		projectile.speed = 4.0f;
//		projectile.direction = (position - transform.position).normalized;
	}

	void OnCollisionEnter2D(Collision2D collider) {

        if(collider.gameObject.tag == "Projectile") {
        	Debug.Log("Dead");
		}
	}
}