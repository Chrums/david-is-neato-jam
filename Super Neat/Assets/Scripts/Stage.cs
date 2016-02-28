using UnityEngine;
using System.Collections;

[System.Serializable]
public class Stage : MonoBehaviour {

	[SerializeField] private Weapon starterWeapon;
	[SerializeField] private Enemy[] enemies;
	[SerializeField] private Transform[] enemySpawnLocations;
	[SerializeField] private float startSpawnEnemyInterval;
	[SerializeField] private float interval;
	private float currentTime = 0.0f;

	private void Awake() {
		
		interval = Random.Range(1.0f, startSpawnEnemyInterval);
	}

	public void Update() {
		
		currentTime += Time.deltaTime;
		if(currentTime >= interval) {
			Enemy enemy = EnemyFactory.sharedInstance.CreateEnemy(enemies[0]); //temp index
			enemy.transform.position = enemySpawnLocations[Random.Range(0, enemySpawnLocations.Length)].position;
			
			interval = Random.Range(1.0f, startSpawnEnemyInterval);
			startSpawnEnemyInterval *= 0.95f;
			currentTime = 0.0f;
		}
	}
}