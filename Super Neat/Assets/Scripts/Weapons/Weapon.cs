using UnityEngine;
using System.Collections;

abstract public class Weapon : MonoBehaviour {

	[SerializeField]
	protected float cooldown = 0.0f;
	static int weaponIndex = 0;
	public int weaponId = 0;
	private float cooldownRemaining = 0.0f;

	public void Start() {
		this.weaponId = Weapon.weaponIndex++;
	}

	public void Update () {
		cooldownRemaining -= Time.deltaTime;
	}

	public void Use (Vector3 direction) {
		if (cooldownRemaining < 0.0f) {
			cooldownRemaining = cooldown;
			Execute (direction);
		}
	}

	abstract public void Execute (Vector3 direction);
}
