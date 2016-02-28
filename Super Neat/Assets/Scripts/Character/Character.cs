using UnityEngine;
using System.Collections;

public abstract class Character : MonoBehaviour {

	public Weapon weapon;
	public float moveSpeed = 1.0f;
	public Animator animator;
	public CircleCollider2D collider;
	protected SpriteRenderer weaponSprite;

	abstract public void Kill();
}