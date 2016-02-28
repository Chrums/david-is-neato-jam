using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	[SerializeField]
	private float expandRate = 0.1f;

	[SerializeField]
	private float startSize = 0.1f;

	[SerializeField]
	private float endSize = 2.0f;

	void Start () {
		this.transform.localScale = new Vector3 (startSize, startSize, 1.0f);
	}

	void Update () {
		if (this.transform.localScale.x < this.endSize) this.transform.localScale += new Vector3 (expandRate, expandRate, 0.0f);
		else this.Destroy(this.gameObject);
	}

}
