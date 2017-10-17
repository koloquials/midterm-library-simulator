using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyVelocity : MonoBehaviour {

	Vector3 inputVector;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalInput = Input.GetAxis ("Horizontal");
		float verticalInput = Input.GetAxis ("Vertical");

		inputVector = transform.right * horizontalInput + transform.forward * verticalInput;

		if (inputVector.magnitude > 1f) {
			inputVector = Vector3.Normalize (inputVector);
		}
	}

	void FixedUpdate(){
		//if (inputVector.magnitude > 0.001f) {
		GetComponent<Rigidbody> ().velocity = inputVector * 25f + Physics.gravity * 0.6f;
		//}
	}
}
