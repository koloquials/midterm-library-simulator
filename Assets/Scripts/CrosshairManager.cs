using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairManager : MonoBehaviour {

	void Update () {
		
		transform.position = Input.mousePosition;
		//Debug.Log (transform.position);
	}
}
