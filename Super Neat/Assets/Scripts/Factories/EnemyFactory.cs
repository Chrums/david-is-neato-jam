using UnityEngine;
using System.Collections;

public class EnemyFactory : MonoBehaviour {

	public static EnemyFactory sharedInstance;

	private void Awake() {

		if(sharedInstance == null) {
			sharedInstance = this;
		} else {
			Destroy(this);
		}
	}

	public Enemy CreateEnemy(Enemy enemyPrefab) {

		Enemy enemy = GameObject.Instantiate(enemyPrefab);
		return enemy;
	}
}