using UnityEngine;
using System.Collections;

public class EnemyFactory : MonoBehaviour {

	public void CreateEnemy(Enemy enemyPrefab) {

		Enemy enemy = GameObject.Instantiate(enemyPrefab);
	}	
}