using UnityEngine;
using System.Collections;

public class GunPosition : MonoBehaviour {

	[SerializeField]
	private Transform characterTransform;

	public void Update () {
		Debug.Log (GetPosition (new Vector3 (1.0f, 1.0f, 0.0f)));
	}

	public Vector3 GetPosition (Vector3 direction) {
		float theta = Vector3.Angle (Vector3.right, direction) * Mathf.Deg2Rad;
		float x = this.gameObject.transform.localScale.x / 2.0f * Mathf.Cos (theta);
		float y = this.gameObject.transform.localScale.z / 2.0f * Mathf.Sin (theta);
		Vector3 position = new Vector3(x, y, direction.z);
		return characterTransform.position + position;
	}

}
