using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMove : MonoBehaviour {

	Rigidbody myRigidBody;
	Vector3 inputVector;

	void Start () {
		myRigidBody = GetComponent<Rigidbody> ();
	}

	void Update () {

		float inputHorizontal = Input.GetAxis ("Horizontal");
		float inputVertical = Input.GetAxis ("Vertical");

		transform.Rotate (0f, inputHorizontal * Time.deltaTime * 90f, 0f);

		inputVector = new Vector3 (0f, 0f, inputVertical);

		if (inputVector.magnitude > 1f)
			inputVector = Vector3.Normalize (inputVector);
	}

	void FixedUpdate(){
		myRigidBody.AddForce (transform.TransformDirection(inputVector) * 20f);
	}
}
