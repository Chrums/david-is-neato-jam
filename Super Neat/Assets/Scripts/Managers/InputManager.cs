using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	public Vector3 movement;
	public Vector3 previousMousePosition;
	public Vector3 currentMousePosition;

	[SerializeField] private Player playerController;
	private Plane groundPlane;

	private void Start() {
	
		groundPlane = new Plane(Vector3.forward, Vector3.zero);
	}

	private void Update () {
		
		previousMousePosition = currentMousePosition;

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float rayDistance;
        if(groundPlane.Raycast(ray, out rayDistance)) {
			currentMousePosition = ray.GetPoint(rayDistance);
			playerController.Aim(currentMousePosition);

			if(Input.GetMouseButton(0)) {
				playerController.Shoot(currentMousePosition);
			}
		}

		movement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0.0f);
		playerController.Move(movement);
	}	
}