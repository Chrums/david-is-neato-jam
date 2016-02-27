using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	public Vector3 movement;
	[SerializeField] private PlayerController playerController;
	private Plane groundPlane;

	private void Start() {
	
		groundPlane = new Plane(Vector3.forward, Vector3.zero);
	}

	private void Update () {
		
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float rayDistance;
        if(groundPlane.Raycast(ray, out rayDistance)) {
			Vector3 position = ray.GetPoint(rayDistance);
			playerController.Aim(position);

			if(Input.GetMouseButtonDown(0)) {
				playerController.Shoot(position);
			}
		}

		movement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0.0f);
		playerController.Move(movement);
	}	
}