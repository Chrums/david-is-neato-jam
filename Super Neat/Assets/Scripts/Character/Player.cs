using UnityEngine;
using System.Collections;

public class Player : Character {

	[SerializeField] private Vector2 ellipse;

	private void Start() {

		weaponSprite = weapon.GetComponent<SpriteRenderer>();
	}	

	public void Move(Vector3 movement) {

		animator.Play(movement != Vector3.zero ? "player_run" : "player_idle");
		Vector3 previousPosition = transform.position;
		transform.position += movement * moveSpeed * Time.deltaTime;
	}

	public void Aim(Vector3 position) {
		
		Vector3 direction = (position - transform.position).normalized;

		
		weaponSprite.sortingOrder = Vector3.Dot(direction, transform.up) > 0.0f ? 0 : 2;

		if(Vector3.Dot(direction, transform.right) < 0.0f) {
			transform.right = -transform.right;
			weaponSprite.transform.localScale = new Vector3(1.0f, -weaponSprite.transform.localScale.y, 1.0f);
		}

		float theta = Vector3.Angle (Vector3.right, direction) * Mathf.Deg2Rad;
		
		float x = ellipse.x / 2.0f * Mathf.Cos (theta);
		float y = ellipse.y / 2.0f * Mathf.Sin (theta);
		if(direction.y < 0.0f)
			y = -y;
		Vector3 gunPosition = new Vector3(x, y, direction.z);
		weaponSprite.transform.position = transform.position + gunPosition;

		weaponSprite.transform.right = direction;
	}
	
	public void Shoot(Vector3 position) {

		if(weapon != null) {
			weapon.Use((position - transform.position).normalized);
		}
	}

	public override void Kill() {
		
		Destroy(gameObject);
	}
		
	void OnCollisionEnter2D(Collision2D collider) {

//        if(collider.gameObject.tag == "Projectile") {
//        	Debug.Log("Dead");
//		}
	}
}