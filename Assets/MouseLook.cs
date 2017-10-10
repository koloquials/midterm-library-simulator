using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseLook : MonoBehaviour {

	public float mouseSensitivity = 70f;
	float verticalLookAngle = 0f;

	void Update () {
		float mouseX = Input.GetAxis ("Mouse X") * Time.deltaTime * mouseSensitivity;
		float mouseY = Input.GetAxis ("Mouse Y") * Time.deltaTime * mouseSensitivity;

		transform.parent.Rotate (0f, mouseX, 0f);
		verticalLookAngle -= mouseY;
		verticalLookAngle = Mathf.Clamp (verticalLookAngle, -85f, 85f);


		transform.localEulerAngles = new Vector3(verticalLookAngle, transform.localEulerAngles.y, 0f);

		if (Input.GetMouseButtonDown (0)) { //left click
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) { //esc
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}
	}
}
