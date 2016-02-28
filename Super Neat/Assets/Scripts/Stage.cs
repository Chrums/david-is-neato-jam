using UnityEngine;
using System.Collections;

[System.Serializable]
public class Stage : MonoBehaviour {

	public Weapon starterWeapon;
	public float spawnEnemyInterval;
	public float currentTime = 0.0f;

	public void Update() {
		
		currentTime += Time.deltaTime;
		if(currentTime >= spawnEnemyInterval) {
			Debug.Log("Spawn Enemy");
			currentTime = 0.0f;
		}
	}
}