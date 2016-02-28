using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	[SerializeField] private Player player;
	[SerializeField] private int stageIndex;
	[SerializeField] private Stage[] stages;

	private void Start() {
		
		GameObject.Instantiate<Stage>(stages[stageIndex]);
	}
}