using UnityEngine;
using System.Collections;

abstract public class Weapon : MonoBehaviour {

	[SerializeField]
	protected GameObject projectile = null;

	public void Start () {
		
	}

	public void Update () {
		
	}

	public void Execute () {
		if (this.ammo > 0) this.Execute();
	}

	virtual protected void Execute () {

	}

}
