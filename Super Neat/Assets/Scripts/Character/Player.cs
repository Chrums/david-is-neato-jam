using UnityEngine;
using System.Collections;

public class Player : Character {

	public SpriteRenderer gunSprite;
	public Animator animator;

	public void Move(Vector3 movement) {

		animator.Play(movement != Vector3.zero ? "player_run" : "player_idle");
		Vector3 previousPosition = transform.position;
		transform.position += movement * moveSpeed * Time.deltaTime;
	}

	public void Aim(Vector3 position) {
		
		Vector3 direction = (position - transform.position).normalized;

		gunSprite.sortingOrder = Vector3.Dot(direction, transform.up) > 0.0f ? 0 : 2;

		if(Vector3.Dot(direction, transform.right) < 0.0f) {
			transform.right = -transform.right;
			gunSprite.transform.localScale = new Vector3(1.0f, -gunSprite.transform.localScale.y, 1.0f);
//			gunSprite.transform.right = -gunSprite.transform.right;
		}
		gunSprite.transform.right = direction;
	}
	
	public void Shoot(Vector3 position) {

		if(weapon != null) {
			weapon.Use((position - transform.position).normalized);
		}
	}

	void OnCollisionEnter2D(Collision2D collider) {

        if(collider.gameObject.tag == "Projectile") {
        	Debug.Log("Dead");
		}
	}
}