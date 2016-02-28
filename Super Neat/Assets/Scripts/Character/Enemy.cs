using UnityEngine;
using System.Collections;

public class Enemy : Character {

	public override void Kill() {
		
		animator.Play("enemy_death");
		Destroy(collider);
//		Destroy(gameObject);
	}
}