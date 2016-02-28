using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {

	public InputManager inputManager;
	public float slowedTimeScale = 0.01f;
	public float fullSpeedTimeScale = 1.0f;

	private void Update() {

		float threshold = 0.01f;
		if(Mathf.Abs(inputManager.movement.x) > threshold || Mathf.Abs(inputManager.movement.y) > threshold) {
			Time.timeScale = fullSpeedTimeScale;
		} else {
			float distance = Vector3.Distance(inputManager.previousMousePosition, inputManager.currentMousePosition);
			if(distance > threshold) {
				Time.timeScale = Mathf.Clamp(fullSpeedTimeScale - distance * 2.5f, slowedTimeScale, fullSpeedTimeScale);
			} else {
				Time.timeScale = slowedTimeScale;
			}
		}
	}
}