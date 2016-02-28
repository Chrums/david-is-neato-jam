using UnityEngine;
using System.Collections;

abstract public class Weapon : MonoBehaviour {

	[SerializeField]
	protected float cooldown = 0.0f;

	private float cooldownRemaining = 0.0f;

	public void Update () {
		cooldownRemaining -= Time.deltaTime;
		Use (Vector3.up);
	}

	public void Use (Vector3 direction) {
		if (cooldownRemaining < 0.0f) {
			cooldownRemaining = cooldown;
			Execute (direction);
		}
	}

	abstract public void Execute (Vector3 direction);

}
